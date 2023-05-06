﻿using AccommodationService.DTO;
using AccommodationService.Mappers;
using AccommodationService.Model;
using AccommodationService.Repository;
using AccommodationService.Service;
using Microsoft.AspNetCore.Mvc;

namespace AccommodationService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AccommodationController : ControllerBase
    {
        private readonly IAccommodationService _accommodationService;
        private readonly IAccommodationRepository _accommodationRepository;
        private readonly IGenericMapper<Accommodation, AccommodationDTO> _mapper;

        public AccommodationController(IAccommodationRepository accommodationRepository, IAccommodationService accommodationService, IGenericMapper<Accommodation, AccommodationDTO> accommodationMapper)
        {
            _accommodationService = accommodationService;
            _accommodationRepository = accommodationRepository;
            _mapper = accommodationMapper;
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            return Ok(_mapper.ToDTO(_accommodationService.GetAll().ToList()));
        }

        [HttpGet("{id}")]
        public ActionResult GetById(string id)
        {
            return Ok(_mapper.ToDTO(_accommodationService.GetById(id)));
        }

        [HttpPost]
        public ActionResult Create(AccommodationDTO accommodationDTO)
        {
            Accommodation accommodation = _mapper.ToModel(accommodationDTO);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_accommodationRepository.IsAccommodationExist(accommodationDTO.Id) == false)
            {
                _accommodationService.Create(accommodation);
                return CreatedAtAction("GetById", new { id = accommodation.Id }, accommodation);
            }
            return BadRequest();
        }
    }
}