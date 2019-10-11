#pragma once
#include "NormalHotel.h"
#include "GoldPlatedToilet.h"
#include "LG55InchTV.h"
#include "IronwoodBed.h"

class BinhMinhHotel : public NormalHotel
{
protected:
	BinhMinhHotel();
public:
	~BinhMinhHotel();
	static BinhMinhHotel& Instance();

	Toilet* MakeToilet();
	Television* MakeTelevision();
	Bed* MakeBed();
};

