using ReservationService.DTO;
using ReservationService.Mappers;
using ReservationService.Model;
using ReservationService.Repository;
using ReservationService.Service;
using Microsoft.AspNetCore.Mvc;

namespace ReservationService.Controllers
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


        [HttpGet("guest/{id}")]
        public ActionResult GetAllGuestReservations(string id)
        {

            return Ok(_mapper.ToDTO(_reservationService.getAllGuestReservations(id).ToList()));
        }


        [HttpGet("undealeted/guest/{id}")]
        public ActionResult GetAllUndealetedGuestReservedReservations(string id)
        {
            return Ok(_mapper.ToDTO(_reservationService.getAllUndealitedGuestReservedReservationsInFuture(id).ToList()));
        }

        [HttpGet("undealeted/host/{id}")]
        public ActionResult GetAllUndealetedHostunreservedReservedReservations(string id)
        {
            return Ok(_mapper.ToDTO(_reservationService.getAllUndeletedUnaprovedHostReservationsInFuture(id).ToList()));
        }


        [HttpPost]
        public ActionResult Create(ReservationDTO reservationDTO)
        {
            
            Reservation reservation = _mapper.ToModel(reservationDTO);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string message = _reservationService.Create(reservation);

            return Ok(message);
           // return CreatedAtAction("GetById", new { id = reservation.Id }, reservation);

        }

        [HttpGet("{id}")]
        public ActionResult GetById(string id)
        {
            return Ok(_mapper.ToDTO(_reservationService.GetById(id)));
        }


        [HttpDelete("cancel/{id}")]
        public ActionResult CancelReservation(string id)
        {

            try
            {
                _reservationService.CancelReservation(id);
                return NoContent();
            }
            catch
            {
                return NotFound();

            }
        }



        [HttpPut("approve/{id}")]
        public ActionResult ApproveReservation(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }            
            try
            {
                Reservation reservation = _reservationService.ApproveReservation(id);
                return Ok(reservation);
            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpPut("disapprove/{id}")]
        public ActionResult DisapproveReservation(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _reservationService.DisapproveReservation(id);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }

        }

    



    }
}
