/***************************
****ROSSI ULYSSE - TP 03****
****************************/

//declaration des variables

const byte BUTTON_PIN = 2;
const byte BUZZER_PIN = 3;

const int NOTES[] = { 262, 294, 330, 349 };  //do ré mi fa

//Fonction pour la mélodie

void melody() {
  digitalWrite(BUZZER_PIN, HIGH);
  for (int i = 0; i < 4; i++) {
    tone(BUZZER_PIN, NOTES[i], 200);
    delay(200);
    noTone(BUZZER_PIN);
  }
  digitalWrite(BUZZER_PIN, LOW);
}

//Fonction pour afficher les messages dans le moniteur

void messages() {
  Serial.println("Boutton pressé !");
  Serial.print("Note joué :");
  for (int i = 0; i < 4; i++) {
    Serial.print(NOTES[i]);
    Serial.print(" ");
  }
}

//Setup

void setup() {
  Serial.begin(9600);
  pinMode(BUTTON_PIN, INPUT);
  pinMode(BUZZER_PIN, OUTPUT);
  digitalWrite(BUZZER_PIN, LOW);
  delay(1000);
}

//Main program

void loop() {
  if (digitalRead(BUTTON_PIN) == HIGH) {
    melody();
    messages();
  }
}
