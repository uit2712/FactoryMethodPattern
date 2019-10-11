#include "pch.h"
#include "Hotel.h"

Hotel::Hotel()
{
}

Hotel::~Hotel()
{
	if (_rooms.size() > 0)
		_rooms.clear();
}

void Hotel::AddRoom(Room* room)
{
	if (room && _rooms.count(room->GetRoomNumber()) == 0)
		_rooms[room->GetRoomNumber()] = room;
}

void Hotel::ViewInfo()
{
	cout << "Khach san co " << _rooms.size() << " phong: " << endl;
	for (std::map<int, Room*>::iterator it = _rooms.begin(); it != _rooms.end(); ++it)
		if (it->second)
			it->second->ViewInfo();
}

Room* Hotel::GetFirstRoom()
{
	if (_rooms.size() == 0)
		return nullptr;

	return _rooms.begin()->second;
}