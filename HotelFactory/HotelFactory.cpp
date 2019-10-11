// HotelFactory.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include "NormalHotel.h"
#include "BinhMinhHotel.h"

int main()
{
	Hotel* hotel = NormalHotel::Instance().CreateHotel(1);
	hotel->ViewInfo();

	hotel = BinhMinhHotel::Instance().CreateHotel(1);
	hotel->ViewInfo();
}
