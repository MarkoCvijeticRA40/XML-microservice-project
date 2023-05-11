using AccommodationService.DTO;
using AccommodationService.Mappers;
using AccommodationService.Model;
using AccommodationService.Repository;
using AccommodationService.Service;
using Microsoft.AspNetCore.Mvc;

namespace AccommodationService.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IGenericMapper<Reservation, ReservationDTO> _mapper;

        public ReservationController(IReservationService reservationService, IGenericMapper<Reservation, ReservationDTO> mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetAllReservations()
        {
            
            return Ok(_mapper.ToDTO(_reservationService.GetAll().ToList()));
        }



        [HttpPost]
        public ActionResult Create(ReservationDTO reservationDTO)
        {
            Reservation reservation = _mapper.ToModel(reservationDTO);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _reservationService.Create(reservation);


            return CreatedAtAction("GetById", new { id = reservation.Id }, reservation);

        }

        [HttpGet("{id}")]
        public ActionResult GetById(string id)
        {
            return Ok(_mapper.ToDTO(_reservationService.GetById(id)));
        }


    }
}
