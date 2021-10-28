#pragma once
#include <iostream>
#include <string>

using namespace std;

struct Weapon {
	int minDamage;
	int maxDamage;
	int reach;
	string damageType;

	//constructor
	Weapon(int min = 1, int max = 4, int r = 5, string type = "Piercing")
	{
		minDamage = min;
		maxDamage = max;
		reach = r;
		damageType = type;
	}
};