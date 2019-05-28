﻿using DVCP.Models;
using DVCP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVCP
{
    public  class UnitOfWork
    {
        private DVCPContext context = new DVCPContext();
        private UserRepository _userRepository;
        private InfoRepository _infoRepository;
        private PostRepository _postRepository;
        private SeriesRepository _seriesRepository;
        public UnitOfWork(DVCPContext _context)
        {
            this.context = _context;
        }
        public SeriesRepository seriesRepository
        {
            get
            {
                if (_seriesRepository == null)
                {
                    _seriesRepository = new SeriesRepository(context);

                }
                return _seriesRepository;
            }
        }
        public PostRepository postRepository
        {
            get
            {
                if(_postRepository== null)
                {
                    _postRepository = new PostRepository(context);
                    
                }
                return _postRepository;
            }
        }
        public InfoRepository infoRepository
        {
            get
            {
                if (_infoRepository == null)
                {
                    _infoRepository = new InfoRepository(context);

                }
                return _infoRepository;
            }
        }
        public UserRepository userRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(context);

                }
                return _userRepository;
            }
        }
        public void Commit()
        {
            context.SaveChanges();
        }
    }
}