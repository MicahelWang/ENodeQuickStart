using ECommon.Components;
using ENodeQuickStart.Infrastructure;

namespace ENodeQuickStart.Domain.Accounts
{/// <summary>注册账号领域服务，封装账号注册时关于账号名唯一的业务规则
 /// </summary>
    [Component]
    public class RegisterAccountService
    {
        private readonly IAccountIndexRepository _accountIndexRepository;

        public RegisterAccountService(IAccountIndexRepository accountIndexRepository)
        {
            _accountIndexRepository = accountIndexRepository;
        }

        public void RegisterAccount(Account account)
        {
            var accountIndex = _accountIndexRepository.FindByAccountName(account.Name);
            if (accountIndex == null)
            {
                _accountIndexRepository.Add(new AccountIndex(account.Id, account.Name));
            }
            else if (accountIndex.AccountId != account.Id)
            {
                throw new DuplicateAccountException(account.Name);
            }
        }
    }
}