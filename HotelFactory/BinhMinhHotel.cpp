#include "pch.h"
#include "BinhMinhHotel.h"

BinhMinhHotel::BinhMinhHotel()
{
}

BinhMinhHotel::~BinhMinhHotel()
{
}

BinhMinhHotel& BinhMinhHotel::Instance()
{
	static BinhMinhHotel hotel;
	return hotel;
}

Toilet* BinhMinhHotel::MakeToilet()
{
	return new GoldPlatedToilet();
}

Television* BinhMinhHotel::MakeTelevision()
{
	return new LG55InchTV();
}

Bed* BinhMinhHotel::MakeBed()
{
	return new IronwoodBed();
}