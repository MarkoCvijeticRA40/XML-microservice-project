using System.Text.RegularExpressions;
using AccommodationService.DTO;
using AccommodationService.Mappers;
using AccommodationService.Model;
using AccommodationService.Repository;
using AccommodationService.Service;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using ProtoService2;

namespace AccommodationService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AccommodationController : ControllerBase
    {
        private readonly IAccommodationService _accommodationService;
        private readonly IAccommodationRepository _accommodationRepository;
        private readonly IGenericMapper<Accommodation, AccommodationDTO> _mapper;

        /* 
        string id = "645f76ba5b45418b5fddca84";
        var channel = new Channel("localhost", 4113, ChannelCredentials.Insecure);
        var client = new AccommodationGrpc.AccommodationGrpcClient(channel);
        var accommodation = client.GetAccommodationInfo(new AccommodationRequest { Id = id }); 
        */

        public AccommodationController(IAccommodationRepository accommodationRepository, IAccommodationService accommodationService, IGenericMapper<Accommodation, AccommodationDTO> accommodationMapper)
        {
            _accommodationService = accommodationService;
            _accommodationRepository = accommodationRepository;
            _mapper = accommodationMapper;
        }

        [HttpGet]
        public ActionResult GetAllAccommodations()
        {   /*
            string id = "645f76ba5b45418b5fddca84";
            var channel = new Channel("localhost", 4113, ChannelCredentials.Insecure);
            var client = new ReservationGrpc.ReservationGrpcClient(channel);
            var accommodation = client.GetReservationInfo(new ReservationRequest { Id = id });
            */

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

            _accommodationService.Create(accommodation);
            return CreatedAtAction("GetById", new { id = accommodation.Id }, accommodation);

   
        }

        [HttpGet("{location}/{guests}/{startDate}/{endDate}")]
        public ActionResult GetAllAccommodationsBySearch(string location, int guests, DateTime startDate, DateTime endDate)
        {

            return Ok(_accommodationService.GetAllAccommodationsBySearch(location, guests, startDate, endDate));

        }

        [HttpPut("{id}")]
        public ActionResult Update(string id, AccommodationDTO accommodationdto)
        {

            Accommodation accommodation = _mapper.ToModel(accommodationdto);

            accommodation.Id = id;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != accommodation.Id)
            {
                return BadRequest();
            }

            try
            {
                _accommodationService.Update(accommodation);
            }
            catch
            {
                return BadRequest();
            }

            return Ok(accommodation);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var accommodation = _accommodationService.GetById(id);
            if (accommodation == null)
            {
                return NotFound();
            }

            _accommodationService.Delete(accommodation);
            return NoContent();
        }

        [HttpDelete("delete/host/{id}")]
        public ActionResult CancelReservation(string id)
        {

            try
            {
                _accommodationService.DeleteHost(id);
                return NoContent();
            }
            catch
            {
                return NotFound();

            }
        }


    }
}
