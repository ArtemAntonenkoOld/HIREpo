using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISharpConvertor.DAL.Abstract;

namespace ISharpConvertor.DAL.Concrate
{
    public class RepositoryHolder : IRepositoryHolder
    {
        Entity.ISharpConvertorEntities _context;
        IAdressRepository _adressRepository;
        IBankRepository _bankRepository;
        ICominsRepository _cominsRepository;
        ICurrencyRepository _currencyRepository;
        ICurrencyRateRepository _currencyRateRepository;
        IExpodentureRepository _expodentureRepository;
        IIncomeRepository _incomeRepository;
        INewsRepository _newsRepository;
        IOperationCominsRepository _operationCominsRepository;
        IOperationDetailsRepository _operationDetailsRepository;
        IOperationRepository _operationRepository;
        IRateRepository _rateRepository;
        IRssUserNewsRepository _rssUserNewsRepository;
        IRssUserRepository _rssUserRepository;
        ISystemCominRepository _systemCominRepository;
        IUserCominRepository _userCominRepository;
        IVideosRepository _videosRepository;
        IFromWhoRepository _fromWhoRepository;
        public RepositoryHolder()
        {
            _context = new Entity.ISharpConvertorEntities();
        }
        public Entity.ISharpConvertorEntities Context
        {
            get
            {
                return _context;
            }

        }
        public IAdressRepository AdressRepository
        {
            get
            {
                if (_adressRepository == null)
                    _adressRepository = new AdressRepository(_context);
                return _adressRepository;
            }
        }
        public ICominsRepository CominsRepository
        {
            get
            {
                if (_cominsRepository == null)
                    _cominsRepository = new CominsRepository(_context);
                return _cominsRepository;
            }
        }
        public IBankRepository BankRepository
        {
            get
            {
                if (_bankRepository == null)
                    _bankRepository = new BankRepository(_context);
                return _bankRepository;
            }
        }
        public ICurrencyRepository CurrencyRepository
        {
            get
            {
                if (_currencyRepository == null)
                    _currencyRepository = new CurrencyRepository(_context);
                return _currencyRepository;
            }
        }
        public ICurrencyRateRepository CurrencyRateRepository
        {
            get
            {
                if (_currencyRateRepository == null)
                    _currencyRateRepository = new CurrencyRateRepository(_context);
                return _currencyRateRepository;
            }
        }
        public IExpodentureRepository ExpodentureRepository
        {
            get
            {
                if (_expodentureRepository == null)
                    _expodentureRepository = new ExpodentureRepository(_context);
                return _expodentureRepository;
            }
        }
        public  IIncomeRepository IncomeRepository

        {
            get
            {
                if (_incomeRepository == null)
                    _incomeRepository = new IncomeRepository(_context);
                return _incomeRepository;
            }
        }
        public INewsRepository NewsRepository
        {
            get
            {
                if (_newsRepository == null)
                    _newsRepository = new NewsRepository(_context);
                return _newsRepository;
            }
        }
        public IOperationCominsRepository OperationCominsRepository
        {
            get
            {
                if (_operationCominsRepository == null)
                    _operationCominsRepository = new OperationCominsRepository(_context);
                return _operationCominsRepository;
            }
        }
        public IOperationDetailsRepository OperationDetailsRepository
        {
            get
            {
                if (_operationDetailsRepository == null)
                    _operationDetailsRepository = new OperationDetailsRepository(_context);
                return _operationDetailsRepository;
            }
        }
        public IRssUserRepository RssUserRepository
        {
            get
            {
                if (_rssUserRepository == null)
                    _rssUserRepository = new RssUserRepository(_context);
                return _rssUserRepository;
            }
        }
        public IOperationRepository OperationRepository
        {
            get
            {
                if (_operationRepository == null)
                    _operationRepository = new OperationRepository(_context);
                return _operationRepository;
            }
        }
        public IRateRepository RateRepository
        {
            get
            {
                if (_rateRepository == null)
                    _rateRepository = new RateRepository(_context);
                return _rateRepository;
            }
        }
        public IRssUserNewsRepository RssUserNewsRepository
        {
            get
            {
                if (_rssUserNewsRepository == null)
                    _rssUserNewsRepository = new RssUserNewsRepository(_context);
                return _rssUserNewsRepository;
            }
        }
        public ISystemCominRepository SystemCominRepository
        {
            get
            {
                if (_systemCominRepository == null)
                    _systemCominRepository = new SystemCominRepository(_context);
                return _systemCominRepository;
            }
        }
        public IUserCominRepository UserCominRepository
        {
            get
            {
                if (_userCominRepository == null)
                    _userCominRepository = new UserCominRepository(_context);
                return _userCominRepository;
            }
        }
        public IVideosRepository VideosRepository
        {
            get
            {
                if (_videosRepository == null)
                    _videosRepository = new VideosRepository(_context);
                return _videosRepository;
            }
        }
        public IFromWhoRepository FromWhoRepository
        {
            get
            {
                if (_fromWhoRepository == null)
                    _fromWhoRepository = new FromWhoRepository(_context);
                return _fromWhoRepository;
            }
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
       
        public void Dispose()
        {
            if (_adressRepository != null)
            {
                _adressRepository.Dispose();
            }
            if (_bankRepository != null)
            {
                _bankRepository.Dispose();
            } 
            if (_cominsRepository != null)
            {
                _cominsRepository.Dispose();
            } if (_currencyRepository != null)
            {
                _currencyRepository.Dispose();
            } if (_bankRepository != null)
            {
                _bankRepository.Dispose();
            } if (_currencyRateRepository != null)
            {
                _currencyRateRepository.Dispose();
            } if (_expodentureRepository != null)
            {
                _expodentureRepository.Dispose();
            } if (_incomeRepository != null)
            {
                _incomeRepository.Dispose();
            } if (_newsRepository != null)
            {
                _newsRepository.Dispose();
            } if (_operationCominsRepository != null)
            {
                _operationCominsRepository.Dispose();
            } if (_operationDetailsRepository != null)
            {
                _operationDetailsRepository.Dispose();
            }
            if (_operationRepository != null)
            {
                _operationRepository.Dispose();
            }
            if (_rateRepository != null)
            {
                _rateRepository.Dispose();
            }
            if (_rssUserNewsRepository != null)
            {
                _rssUserNewsRepository.Dispose();
            }
            if (_rssUserRepository != null)
            {
                _rssUserRepository.Dispose();

            }
            if (_systemCominRepository != null)
            {
                _systemCominRepository.Dispose();
            }
            if (_userCominRepository != null)
            {
                _userCominRepository.Dispose();
            }
            if (_videosRepository != null)
            {
                _videosRepository.Dispose();
            }
            if (_fromWhoRepository != null)
            {
                _fromWhoRepository.Dispose();
            }
        }
    }
}
