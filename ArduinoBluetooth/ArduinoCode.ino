#include <SoftwareSerial.h>

SoftwareSerial bluetooth(10, 11); // RX, TX

const int ledPins[] = {2, 3, 4, 5}; // LED pinleri

void setup() {
  Serial.begin(9600);
  bluetooth.begin(9600);
  Serial.println("Bluetooth modülü hazýr.");

  for (int i = 0; i < 4; i++) {
    pinMode(ledPins[i], OUTPUT);
    digitalWrite(ledPins[i], LOW);
  }
}

void loop() {
  if (bluetooth.available()) {
    String dataReceived = bluetooth.readStringUntil('\n');
    Serial.print("Gelen veri: ");
    Serial.println(dataReceived);
    controlLEDs(dataReceived);
  }

  if (Serial.available()) {
    String dataToSend = Serial.readStringUntil('\n');
    bluetooth.println(dataToSend);
    Serial.print("Gönderilen veri: ");
    Serial.println(dataToSend);
  }
}

void controlLEDs(String command) {
  if (command == "LED1_ON") {
    digitalWrite(ledPins[0], HIGH);
    bluetooth.println("LED1_ON");
  } else if (command == "LED1_OFF") {
    digitalWrite(ledPins[0], LOW);
    bluetooth.println("LED1_OFF");
  } else if (command == "LED2_ON") {
    digitalWrite(ledPins[1], HIGH);
    bluetooth.println("LED2_ON");
  } else if (command == "LED2_OFF") {
    digitalWrite(ledPins[1], LOW);
    bluetooth.println("LED2_OFF");
  } else if (command == "LED3_ON") {
    digitalWrite(ledPins[2], HIGH);
    bluetooth.println("LED3_ON");
  } else if (command == "LED3_OFF") {
    digitalWrite(ledPins[2], LOW);
    bluetooth.println("LED3_OFF");
  } else if (command == "LED4_ON") {
    digitalWrite(ledPins[3], HIGH);
    bluetooth.println("LED4_ON");
  } else if (command == "LED4_OFF") {
    digitalWrite(ledPins[3], LOW);
    bluetooth.println("LED4_OFF");
  } else {
    bluetooth.println("Geçersiz komut.");
  }
}
