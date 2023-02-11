
DROP DATABASE IF EXISTS gundam;

CREATE DATABASE gundam;

USE gundam;

CREATE TABLE mobile_suit
(
  GundamId INT UNIQUE NOT NULL AUTO_INCREMENT,
  Model NVARCHAR(50) NOT NULL,
  Pilot NVARCHAR(50) NOT NULL
);

INSERT INTO mobile_suit(Model, Pilot) VALUES
  ('RX-78-2', 'Amuro Ray');