#pragma once
#include <cstdlib>
#include <iostream>

class Die {
private: 
	int sides;
	int currentRoll;
	int previousRoll;

public: 
	int getSides() {
		return sides;
	}
	int getCurrentRoll() {
		return currentRoll;
	}
	int getPreviousRoll() {
		return previousRoll;
	}

	//Mutators
	void setSides(int s) {
		if (s > 0) {
			sides = s;
		}
	}
	void setCurrentRoll(int r) {
		if (r > 0 && r < sides) {
			currentRoll = r;
		}
	}
	void setPreviousRoll(int r) {
		if (r > 0 && r < sides) {
			previousRoll = r;
		}
	}

	Die(int s = 6, int cr = 1, int pr = 1) {
		setSides(s);
		setCurrentRoll(cr);
		setPreviousRoll(pr);
	}

public:
	int roll() {
		srand(time(NULL));
		setPreviousRoll(currentRoll);
		setCurrentRoll(rand() % (sides + 1));
		
		return getCurrentRoll();
	}
};