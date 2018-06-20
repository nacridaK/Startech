union
{
  double db;
  byte by[4];
} enlem;
union
{
  double db;
  byte by[4];
} boylam;

void setup() 
{
  pinMode(A0,INPUT);
  Serial.begin(9600);
  enlem.db = 42.15452316123456789;
  boylam.db = 28.15452316123456789;
}

void loop() 
{
  enlem.db = enlem.db + 0.00001;
  boylam.db = boylam.db + 0.00001;
  Serial.write(enlem.by[0]);
  Serial.write(enlem.by[1]);
  Serial.write(enlem.by[2]);
  Serial.write(enlem.by[3]);
  Serial.write(boylam.by[0]);
  Serial.write(boylam.by[1]);
  Serial.write(boylam.by[2]);
  Serial.write(boylam.by[3]);
  /*Serial.println(enlem.by[0]);
  Serial.println(enlem.by[1]);
  Serial.println(enlem.by[2]);
  Serial.println(enlem.by[3]);
  Serial.println(boylam.by[0]);
  Serial.println(boylam.by[1]);
  Serial.println(boylam.by[2]);
  Serial.println(boylam.by[3]);*/
  delay(50);
}
