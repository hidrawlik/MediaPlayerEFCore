﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediaPlayer.BLL.Interfaces.IServices;
using MediaPlayer.DAL.Interfaces;
using MediaPlayer.DAL.Entities;
using MediaPlayer.BLL.DTOs;
using AutoMapper;

namespace MediaPlayer.BLL.Services
{
    public class GenreService : SetOfFields, IGenreService
    {
        public GenreService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }

        public async Task AddGenreAsync(GenreDTO genreDTO)
        {
            var genre = mapper.Map<Genre>(genreDTO);

            await unitOfWork.GenreRepository.Add(genre);
        }

        public async Task DeleteGenreAsync(GenreDTO genreDTO)
        {
            var genre = mapper.Map<Genre>(genreDTO);

            await unitOfWork.GenreRepository.Delete(genre);
        }

        public async Task<GenreDTO> GetGenreAsync(int Id)
        {
            var genre = await unitOfWork.GenreRepository.Get(Id);

            return mapper.Map<GenreDTO>(genre);
        }

        public async Task<IEnumerable<GenreDTO>> GetAllGenresAsync()
        {
            var genreList = await unitOfWork.GenreRepository.GetAll();

            return mapper.Map<IEnumerable<GenreDTO>>(genreList);
        }

        public async Task UpdateGenreAsync(GenreDTO genreDTO)
        {
            var genre = mapper.Map<Genre>(genreDTO);

            await unitOfWork.GenreRepository.Update(genre);
        }
    }
}