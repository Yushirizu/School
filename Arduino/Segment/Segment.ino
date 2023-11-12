#define BUTTON_PIN 2
#define SWITCH_PIN 3
#define START_PIN 4
#define END_PIN 10
#define NUM_DIGITS 10
#define NUM_SEGMENTS 7

int nbr[NUM_DIGITS][NUM_SEGMENTS] = {
    {0, 0, 0, 0, 0, 0, 1},
    {1, 0, 0, 1, 1, 1, 1},
    {0, 0, 1, 0, 0, 1, 0},
    {0, 0, 0, 0, 1, 1, 0},
    {1, 0, 0, 1, 1, 0, 0},
    {0, 1, 0, 0, 1, 0, 0},
    {0, 1, 0, 0, 0, 0, 0},
    {0, 0, 0, 1, 1, 1, 1},
    {0, 0, 0, 0, 0, 0, 0},
    {0, 0, 0, 0, 1, 0, 0},
};

void setup() {
  for(int x = START_PIN; x <= END_PIN; x++){
    pinMode(x, OUTPUT);
  }
  pinMode(BUTTON_PIN, INPUT);
  pinMode(SWITCH_PIN, INPUT);
}

void displayNumber(int num) {
  for(int j = START_PIN; j <= END_PIN; j++){
    digitalWrite(j, nbr[num][j - START_PIN]);
  }
}

void loop() {
  if(digitalRead(BUTTON_PIN) == HIGH){
    if(digitalRead(SWITCH_PIN) == HIGH){
      for(int i = 0; i < NUM_DIGITS; i++){
        displayNumber(i);
        delay(1000);
      }
    } else {
      for(int i = NUM_DIGITS - 1; i >= 0; i--){
        displayNumber(i);
        delay(1000);
      }
    }
  } else {
    for(int j = START_PIN; j <= END_PIN; j++){
      digitalWrite(j, HIGH);
    }
  }
}