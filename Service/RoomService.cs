using AttendanceMananagmentProject.Dto.Room;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;
using AutoMapper;

namespace AttendanceMananagmentProject.Service
{
    public class RoomService : IRoomService
    {

        private IRoomRepository roomRepository;
        private IMapper mapper;

        public RoomService(IRoomRepository roomRepository, IMapper mapper)
        {
            this.roomRepository = roomRepository;
            this.mapper = mapper;
        }

        public RoomDTO Add(Room room)
        {
            Room add = roomRepository.Add(room);
            return mapper.Map<Room, RoomDTO>(room);
        }

        public RoomDTO Delete(int id)
        {
            Room delete = roomRepository.Delete(id);
            return mapper.Map<Room, RoomDTO>(delete);


        }

        public RoomDTO Get(int id)
        {
            Room room = roomRepository.Get(id);
            return mapper.Map<Room, RoomDTO>(room);
        }

        public List<RoomDTO> List()
        {
            List<Room> rooms = roomRepository
                 .List()
                 .ToList();
            return mapper.Map<List<Room>, List<RoomDTO>>(rooms);

        }

        public RoomDTO Update(Room room)
        {
            Room update = roomRepository.Update(room);
            return mapper.Map<Room, RoomDTO>(update);
        }
    }
}
