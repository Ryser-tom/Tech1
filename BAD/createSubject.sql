BEGIN TRANSACTION;
DROP TABLE IF EXISTS `type`;
CREATE TABLE IF NOT EXISTS `type` (
	`idType`	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
	`nameType`	TEXT NOT NULL UNIQUE
);
DROP TABLE IF EXISTS `teacher`;
CREATE TABLE IF NOT EXISTS `teacher` (
	`idTeacher`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`nameTeacher`	TEXT,
	`firstnameTeacher`	TEXT,
	`telTeacher`	TEXT UNIQUE,
	`emailTeacher`	TEXT UNIQUE
);
DROP TABLE IF EXISTS `subject`;
CREATE TABLE IF NOT EXISTS `subject` (
	`idSubject`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`typeSubject`	INTEGER NOT NULL,
	`nameSubject`	TEXT NOT NULL,
	`dateCreateSubject`	TEXT,
	`placeSubject`	TEXT,
	`titleSubject`	TEXT,
	`environmentSubject`	TEXT,
	`objectiveSubject`	TEXT,
	`descriptionSubject`	TEXT,
	`conceptualModelSubject`	TEXT,
	`stepsInventorySubject`	TEXT,
	`equipmentSubject`	TEXT,
	`deliverableSubject`	TEXT,
	`mesurableElementsSubject`	TEXT,
	`idCreator`	INTEGER NOT NULL
);
DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
	`idStudent`	INTEGER,
	`nameStudent`	TEXT,
	`firstnameStudent`	TEXT,
	`telStudent`	TEXT UNIQUE,
	`emailStudent`	TEXT UNIQUE
);
COMMIT;
