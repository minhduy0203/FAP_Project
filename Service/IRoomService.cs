using AttendanceMananagmentProject.Dto.Room;
using AttendanceMananagmentProject.Models;
using AttendanceMananagmentProject.Repository;

namespace AttendanceMananagmentProject.Service
{
    public interface IRoomService
    {

        RoomDTO Get(int id);
        List<RoomDTO> List();

        RoomDTO Add(RoomDTO room);
        RoomDTO Delete(int id);

        RoomDTO Update(RoomDTO room);


    }
}
