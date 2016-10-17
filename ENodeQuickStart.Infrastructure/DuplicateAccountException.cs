using System;

namespace ENodeQuickStart.Infrastructure
{
    public class DuplicateAccountException : Exception
    {
        public DuplicateAccountException(string accountName) : base("重复的账号名称：" + accountName) { }
    }
}