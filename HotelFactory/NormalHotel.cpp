#include "pch.h"
#include "NormalHotel.h"

NormalHotel::NormalHotel()
{
}

NormalHotel::~NormalHotel()
{
}

NormalHotel& NormalHotel::Instance()
{
	static NormalHotel hotel;
	return hotel;
}

Hotel* NormalHotel::CreateHotel(int totalRooms)
{
	Hotel* hotel = new Hotel();

	for (unsigned int i = 0; i < totalRooms; i++)
	{
		Room* room = MakeRoom(i + 1);
		room->AddAirConditioner(MakeAirConditioner());
		room->AddBed(MakeBed());
		room->AddTelevision(MakeTelevision());
		room->AddToilet(MakeToilet());
		hotel->AddRoom(room);
	}

	return hotel;
}

Room* NormalHotel::MakeRoom(int roomNumber)
{
	return new Room(roomNumber);
}

Toilet* NormalHotel::MakeToilet()
{
	return new Toilet();
}

Bed* NormalHotel::MakeBed()
{
	return new Bed();
}

Television* NormalHotel::MakeTelevision()
{
	return new Television();
}

AirConditioner* NormalHotel::MakeAirConditioner()
{
	return new AirConditioner();
}