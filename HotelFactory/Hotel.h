#pragma once
#include "Room.h"
#include <map>

class Hotel
{
protected:
	map<int, Room*>		_rooms;
public:
	Hotel();
	~Hotel();

	void AddRoom(Room* room);
	virtual void ViewInfo();
protected:
	Room* GetFirstRoom();
};

