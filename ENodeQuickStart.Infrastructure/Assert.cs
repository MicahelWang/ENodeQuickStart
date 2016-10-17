using System;

namespace ENodeQuickStart.Infrastructure
{
    public class Assert
    {
        public static void IsNotNull(string name, object obj)
        {
            if (obj == null)
            {
                throw new ArgumentException($"{name}不能为空");
            }
        }
        public static void IsNotNullOrEmpty(string name, string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException($"{name}不能为空");
            }
        }
        public static void IsNotNullOrWhiteSpace(string name, string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException($"{name}不能为空");
            }
        }
        public static void AreEqual(string id1, string id2, string errorMessageFormat)
        {
            if (id1 != id2)
            {
                throw new ArgumentException(string.Format(errorMessageFormat, id1, id2));
            }
        }
    }
}
