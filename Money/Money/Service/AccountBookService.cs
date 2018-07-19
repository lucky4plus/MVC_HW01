using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Money.Models;
using Money.Repository;
using Money.Models.ViewModels;
namespace Money.Service
{
    public class AccountBookService
    {
        private readonly IRepository<AccountBook> _accountBookRepository;

        public AccountBookService(IUnitOfWork unitOfWork)
        {
            _accountBookRepository = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<MoneyViewModel> Lookup()
        {
            var source = _accountBookRepository.LookupAll();
            var result = source.Select(acountBook => new MoneyViewModel()
            {
                Id = acountBook.Id,
                Category = acountBook.Categoryyy,
                Date = acountBook.Dateee,
                Money = acountBook.Amounttt,
                Remark = acountBook.Remarkkk
            });
            return result;
        }
        /// <summary>
        /// 取一筆記帳明細
        /// </summary>
        /// <param name="accountBookId"></param>
        /// <returns></returns>
        public MoneyViewModel GetSingle(Guid accountBookId)
        {
            var source = _accountBookRepository.GetSingle(x => x.Id == accountBookId);
            return new MoneyViewModel
            {
                Id = source.Id,
                Category = source.Categoryyy,
                Date = source.Dateee,
                Money = source.Amounttt,
                Remark = source.Remarkkk
            };
        }
        /// <summary>
        /// 新增記帳明細
        /// </summary>
        /// <param name="accountBook"></param>
        public void Add(MoneyViewModel accountBook)
        {
            _accountBookRepository.Create(new AccountBook
            {
                Id = accountBook.Id,
                Categoryyy = accountBook.Category,
                Dateee = accountBook.Date,
                Amounttt = accountBook.Money,
                Remarkkk = accountBook.Remark
            });
        }
        /// <summary>
        /// 編輯記帳明細
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageData"></param>
        public void Edit(Guid id, MoneyViewModel pageData)
        {
            var oldData = _accountBookRepository.GetSingle(x => x.Id == id);
            if (oldData != null)
            {
                oldData.Categoryyy = pageData.Category;
                oldData.Dateee = pageData.Date;
                oldData.Remarkkk = pageData.Remark;
                oldData.Amounttt = pageData.Money;
            }
        }
        /// <summary>
        /// 刪除記帳明細
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            _accountBookRepository.Remove(_accountBookRepository.GetSingle(x => x.Id == id));
        }

    }
}