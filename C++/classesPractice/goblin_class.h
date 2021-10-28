#pragma once
#include <iostream>
#include <string>
#include <cmath>
#include <ctime>

using namespace std;

class Goblin
{
private:
	string name = "Snarrk";
	int HP;
	int attack;
	int def;

	bool angry = false;

public:
	//Accessors
	string getName()
	{
		return name;
	}
	int getHP()
	{
		return HP;
	}
	int getAttack()
	{
		return attack;
	}
	int getDef()
	{
		return def;
	}

	//Mutators
	void setName(string nName)
	{
		if (nName != "")
			name = nName;
		else
			cout << "Invalid name.\nName not set.";
	}
	void setHP(int health)
	{
		if (health > 0)
			HP = health;
		else
			cout << "Invalid HP.\nHP not set.";
	}
	void setAttack(int att)
	{
		if (att >= 0)
			attack = att;
		else
			cout << "Invalid attack.\nAttack not set.";
	}
	void setDef(int defence)
	{
		if (defence >= 0)
			def = defence;
		else
			cout << "Invalid defence.\nDefence not set.";
	}

	//Constructors Var names unrelated
	Goblin(string nName = "Snarrkeldor", int health = 5, int att = 1, int defen = 1)
	{
		setName(nName);
		setHP(health);
		setAttack(att);
		setDef(defen);
	}
	
private:
	void screech()
	{
		cout << "The goblin screeched at you.";
	}
	void stab()
	{
		srand(time(NULL));
		cout << "Stab! -" << (rand() % 5 + 1) << " HP";
	}
	void sneak()
	{
		cout << "The goblin didn't notice you.";
	}
	void dead()
	{
		cout << name << " died.";
	}

public:
	void provoke()
	{
		if (angry == false)
			screech();
		else
			stab();
	}
	void stealth()
	{
		sneak();
	}
	void takeDamage()
	{
		
		dead();
	}
};