#pragma once
#include <cstdlib>
#include <iostream>

class die {
private: 
	int sides;
	int currentRoll;
	int previousRoll;

public: 
	void getSides() {
		return sides;
	}
	void getCurrentRoll() {
		return currentRoll;
	}
	void getPreviousRoll() {
		return previousRoll;
	}

	//Mutators
	int setSides(int s) {
		if (s > 0) {
			sides = s;
		}
	}
	int setCurrentRoll(int r) {
		if (r > 0 && r < sides) {
			currentRoll = r;
		}
	}
	int setPreviousRoll(int r) {
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
		setCurrentRoll(rand % (sides + 1) + 1);
		
		getCurrentRoll();
	}
};