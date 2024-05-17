using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System;
using System.IO.Compression;
using System.Drawing;

namespace Serialization
{
    [Serializable]
    public struct RenderData
    {
        public int width;
        public int height;
        public bool loop;
        public int fps;
        public FrameData[] frames;
    }

    [Serializable]
    public struct FrameData
    {
        public char[] asciiData;
        public ushort[] attributes;
    }


    public static class Serializer
    {
        public static byte[] ToByteArray<T>(this T graph)
        {
            using (var ms = new MemoryStream())
            {
                graph.Serialize(ms);

                return ms.ToArray();
            }
        }

        public static T FromByteArray<T>(this byte[] serialized)
        {
            using (var ms = new MemoryStream(serialized))
            {
                return ms.DeSerialize<T>();
            }
        }

        public static void SerializeAndCompress<T>(this T graph, Stream target)
        {
            using (var memoryStream = new MemoryStream())
            {
                graph.Serialize(memoryStream);

                using (var deflateStream = new DeflateStream(target, CompressionMode.Compress))
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    memoryStream.CopyTo(deflateStream);
                }
            }
        }

        public static T DecompressAndDeserialize<T>(this Stream source)
        {
            using (var memoryStream = new MemoryStream())
            using (var deflateStream = new DeflateStream(source, CompressionMode.Decompress))
            {
                deflateStream.CopyTo(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);

                return (T)memoryStream.DeSerialize<T>();
            }
        }

        public static void Serialize<T>(this T graph, Stream target)
        {
            IFormatter formatter = new BinaryFormatter();
            formatter.Binder = TypeOnlyBinder.Default;

            formatter.Serialize(target, graph);
        }

        public static T DeSerialize<T>(this Stream source)
        {
            IFormatter formatter = new BinaryFormatter();

            formatter.Binder = TypeOnlyBinder.Default;
            return (T)formatter.Deserialize(source);
        }



        public class TypeOnlyBinder : SerializationBinder
        {
            public override Type BindToType(string assemblyName, string typeName)
            {
                if (assemblyName.Equals("NA"))
                    return Type.GetType(typeName);
                else
                    return defaultBinder.BindToType(assemblyName, typeName);
            }

            public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
            {
                // specify a neutral code for the assembly name to be recognized by the BindToType method.
                assemblyName = "NA";
                typeName = serializedType.FullName;
            }

            private static SerializationBinder defaultBinder = new BinaryFormatter().Binder;

            private static object locker = new object();
            private static TypeOnlyBinder _default = null;

            public static TypeOnlyBinder Default
            {
                get
                {
                    lock (locker)
                    {
                        if (_default == null)
                            _default = new TypeOnlyBinder();
                    }
                    return _default;
                }
            }
        }
    }
}