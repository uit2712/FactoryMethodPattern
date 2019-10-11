#pragma once
#include "Toilet.h"
#include "Bed.h"
#include "Television.h"
#include "AirConditioner.h"
#include <vector>

using namespace std;

class Room
{
protected:
	int							_roomNumber;
	vector<Toilet*>				_toilets;
	vector<Bed*>				_beds;
	vector<Television*>			_televisions;
	vector<AirConditioner*>		_airConditioners;
public:
	Room(int roomNumber);
	~Room();

	int GetRoomNumber();
	void AddToilet(Toilet* toilet);
	void AddBed(Bed* bed);
	void AddTelevision(Television* television);
	void AddAirConditioner(AirConditioner* airConditioner);
	virtual void ViewInfo();
};

