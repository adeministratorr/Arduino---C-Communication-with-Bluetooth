#include <SoftwareSerial.h>

SoftwareSerial bluetooth(10, 11); // RX, TX

void setup() {
  Serial.begin(9600);
  bluetooth.begin(9600);
  Serial.println("Bluetooth mod�l� haz�r.");
}

void loop() {
  if (bluetooth.available()) {
    String dataReceived = bluetooth.readStringUntil('\n');
    Serial.print("Gelen veri: ");
    Serial.println(dataReceived);
  }

  if (Serial.available()) {
    String dataToSend = Serial.readStringUntil('\n');
    bluetooth.println(dataToSend);
    Serial.print("G�nderilen veri: ");
    Serial.println(dataToSend);
  }
}
