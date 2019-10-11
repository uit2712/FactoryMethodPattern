#pragma once
#include "Hotel.h"

class NormalHotel
{
protected:
	NormalHotel();
public:
	~NormalHotel();

	static NormalHotel& Instance();
	virtual Hotel* CreateHotel(int totalRooms);
	virtual Room* MakeRoom(int roomNumber);
	virtual Toilet* MakeToilet();
	virtual Bed* MakeBed();
	virtual Television* MakeTelevision();
	virtual AirConditioner* MakeAirConditioner();
};

