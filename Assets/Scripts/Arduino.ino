int UpDown = 0;
int LeftRight = 0;

void setup() {
  // Listen to serial port 9600
  Serial.begin(9600);
}

void loop() {
	// Analog pins
	UpDown = analogRead(A0);
	LeftRight = analogRead(A1);
  
	// Joystick
	Serial.print(UD, DEC);
	Serial.print(",");
	Serial.print(LR, DEC);
	delay(200);
}