﻿using CasualShop.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CasualShop.DAL.Repository
{
    public class DataManager
    {
        private readonly IClothesRepository _clothesRepository;
        private readonly IBrandsRepository _brandsRepository;
        private readonly ITagsRepository _tagsRepository;
        private readonly IBasketsRepository _basketsRepository;
        private readonly IImagesRepository _imagesRepository;

        public DataManager(IClothesRepository clothesRepository, 
            ITagsRepository tagsRepository, 
            IBrandsRepository brandsRepository,
            IBasketsRepository basketsRepository,
            IImagesRepository imagesRepository)
        {
            _clothesRepository = clothesRepository;
            _brandsRepository = brandsRepository;
            _tagsRepository = tagsRepository;
            _basketsRepository = basketsRepository;
            _imagesRepository = imagesRepository;
        }

        public IClothesRepository Clothes { get { return _clothesRepository; } }
        public IBrandsRepository Brands { get { return _brandsRepository; } }
        public ITagsRepository Tags { get { return _tagsRepository; } }
        public IBasketsRepository Baskets { get { return _basketsRepository; } }
        public IImagesRepository Images { get { return _imagesRepository; } }

    }
}
