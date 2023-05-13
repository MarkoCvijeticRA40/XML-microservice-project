using AccommodationService.DTO;
using AccommodationService.Enums;
using AccommodationService.Model;

namespace AccommodationService.Mappers
{
    public class AccommodationMapper : IGenericMapper<Accommodation, AccommodationDTO>
    {

        public AccommodationDTO ToDTO(Accommodation accommodation)
        {
            AccommodationDTO accommodationDTO = new AccommodationDTO();
            accommodationDTO.Id = accommodation.Id;
            accommodationDTO.Name = accommodation.Name;
            accommodationDTO.Location = accommodation.Location;
            accommodationDTO.Facilities = accommodation.Facilities;
            accommodationDTO.Photos = accommodation.Photos;
            accommodationDTO.MinCapacity = accommodation.MinCapacity;
            accommodationDTO.MaxCapacity = accommodation.MaxCapacity;
            accommodationDTO.StartDate = accommodation.StartDate;
            accommodationDTO.EndDate = accommodation.EndDate;
            accommodationDTO.Price = accommodation.Price;
            accommodationDTO.Grade = accommodation.Grade;
            accommodationDTO.HostId = accommodation.HostId;

            if (accommodation.ReservationType == ReservationType.Autoautomatically)
            {
                accommodationDTO.ReservationType = "Automatically";
            }
            if (accommodation.ReservationType == ReservationType.WithApproval)
            {
                accommodationDTO.ReservationType = "WithApproval";
            }


            return accommodationDTO;
        }

        public List<AccommodationDTO> ToDTO(List<Accommodation> accommodations)
        {
            List<AccommodationDTO> accomodationDTOs = new List<AccommodationDTO>();

            foreach (Accommodation accommodation in accommodations)
            {
                AccommodationDTO accommodationDTO = new AccommodationDTO();

                accommodationDTO.Id = accommodation.Id;
                accommodationDTO.Name = accommodation.Name;
                accommodationDTO.Location = accommodation.Location;
                accommodationDTO.Facilities = accommodation.Facilities;
                accommodationDTO.Photos = accommodation.Photos;
                accommodationDTO.MinCapacity = accommodation.MinCapacity;
                accommodationDTO.MaxCapacity = accommodation.MaxCapacity;
                accommodationDTO.StartDate = accommodation.StartDate;
                accommodationDTO.EndDate = accommodation.EndDate;
                accommodationDTO.Price = accommodation.Price;
                accommodationDTO.Grade = accommodation.Grade;
                accommodationDTO.HostId = accommodation.HostId;


                if (accommodation.ReservationType == ReservationType.Autoautomatically)
                {
                    accommodationDTO.ReservationType = "Automatically";
                }
                if (accommodation.ReservationType == ReservationType.WithApproval)
                {
                    accommodationDTO.ReservationType = "WithApproval";
                }

                accomodationDTOs.Add(accommodationDTO);
            }

            return accomodationDTOs;
        }

        public Accommodation ToModel(AccommodationDTO accommodationDTO)
        {
            Accommodation accommodation = new Accommodation();
            accommodation.Id = accommodationDTO.Id;
            accommodation.Name = accommodationDTO.Name;
            accommodation.Location = accommodationDTO.Location;
            accommodation.Facilities = accommodationDTO.Facilities;
            accommodation.Photos = accommodationDTO.Photos;
            accommodation.MinCapacity = accommodationDTO.MinCapacity;
            accommodation.MaxCapacity = accommodationDTO.MaxCapacity;
            accommodation.StartDate = accommodationDTO.StartDate;
            accommodation.EndDate = accommodationDTO.EndDate;
            accommodation.Price = accommodationDTO.Price;
            accommodation.Grade = accommodationDTO.Grade;
            accommodation.HostId = accommodationDTO.HostId;


            if (accommodationDTO.ReservationType.Equals("Automatically"))
            {
                accommodation.ReservationType = ReservationType.Autoautomatically;
            }
            if (accommodationDTO.ReservationType.Equals("WithApproval"))
            {
                accommodation.ReservationType = ReservationType.Autoautomatically;
            }

            return accommodation;
        }

        public List<Accommodation> ToModel(List<AccommodationDTO> accommodationDTOs)
        {
            List<Accommodation> accommodations = new List<Accommodation>();

            foreach (AccommodationDTO accommodationDTO in accommodationDTOs)
            {
                Accommodation accommodation = new Accommodation();

                accommodation.Id = accommodationDTO.Id;
                accommodation.Name = accommodationDTO.Name;
                accommodation.Location = accommodationDTO.Location;
                accommodation.Facilities = accommodationDTO.Facilities;
                accommodation.Photos = accommodationDTO.Photos;
                accommodation.MinCapacity = accommodationDTO.MinCapacity;
                accommodation.MaxCapacity = accommodationDTO.MaxCapacity;
                accommodation.StartDate = accommodationDTO.StartDate;
                accommodation.EndDate = accommodationDTO.EndDate;
                accommodation.Price = accommodationDTO.Price;
                accommodation.Grade = accommodationDTO.Grade;
                accommodation.HostId = accommodationDTO.HostId;

                if (accommodationDTO.ReservationType.Equals("Automatically"))
                {
                    accommodation.ReservationType = ReservationType.Autoautomatically;
                }
                if (accommodationDTO.ReservationType.Equals("WithApproval"))
                {
                    accommodation.ReservationType = ReservationType.Autoautomatically;
                }
                accommodations.Add(accommodation);
            }
            return accommodations;

        }
    }
}
