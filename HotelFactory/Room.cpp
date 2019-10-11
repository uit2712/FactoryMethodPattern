#include "pch.h"
#include "Room.h"

Room::Room(int roomNumber)
{
	_roomNumber = roomNumber;
}

Room::~Room()
{
	if (_toilets.size() > 0)
		_toilets.clear();

	if (_beds.size() > 0)
		_beds.clear();

	if (_televisions.size() > 0)
		_televisions.clear();

	if (_airConditioners.size() > 0)
		_airConditioners.clear();
}

int Room::GetRoomNumber()
{
	return _roomNumber;
}

void Room::AddToilet(Toilet* toilet)
{
	if (toilet)
		_toilets.push_back(toilet);
}

void Room::AddBed(Bed* bed)
{
	if (bed)
		_beds.push_back(bed);
}

void Room::AddTelevision(Television* television)
{
	if (television)
		_televisions.push_back(television);
}

void Room::AddAirConditioner(AirConditioner* airConditioner)
{
	if (airConditioner)
		_airConditioners.push_back(airConditioner);
}

void Room::ViewInfo()
{
	cout << "Phong so " << _roomNumber
		<< ": co " << _airConditioners.size() << " may dieu hoa, "
		<< _beds.size() << " giuong ngu, "
		<< _televisions.size() << " tivi, "
		<< _toilets.size() << " toilet" << endl;

	if (_airConditioners.size() > 0)
		_airConditioners[0]->ViewInfo();
	if (_beds.size() > 0)
		_beds[0]->ViewInfo();
	if (_televisions.size() > 0)
		_televisions[0]->ViewInfo();
	if (_toilets.size() > 0)
		_toilets[0]->ViewInfo();
	cout << endl;
}