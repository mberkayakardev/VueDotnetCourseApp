﻿using AutoMapper;

namespace QuizApp.Services.Abstract.Base
{
    public abstract class BaseServices : IBaseServices
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;
        public BaseServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
