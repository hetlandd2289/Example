/* AUTHOR: DRAKE HETLAND
DATE: 12-14-2020
DESCRIPTION: DATABASE AND SQL FINAL */

USE WORLD;
DROP VIEW IF EXISTS LARGE_COUNTRY;
DROP VIEW IF EXISTS EUROPEAN_CITIES;
/*DROP INDEX COUNTRY_INDEX ON COUNTRY;*/
DROP PROCEDURE IF EXISTS POPULATION_SORTER;
DROP PROCEDURE IF EXISTS TEMPORARY_TABLE;

/* QUESTION 1 */
CREATE VIEW LARGE_COUNTRY AS 
SELECT COUNTRY_CODE, COUNTRY_NAME, CONTINENT
FROM COUNTRY WHERE SURFACE_AREA > 3000000;

SELECT COUNTRY_CODE, COUNTRY_NAME, CONTINENT
FROM LARGE_COUNTRY
WHERE CONTINENT = 'Asia';

SELECT COUNTRY_CODE, COUNTRY_NAME, CONTINENT
FROM COUNTRY
WHERE SURFACE_AREA > 3000000
AND CONTINENT = 'Asia';

/* QUESTION 2 */
CREATE VIEW EUROPEAN_CITIES AS
SELECT CITY_NAME, COUNTRY_NAME, Y.POPULATION, Y.COUNTRY_CODE
FROM CITY Y, COUNTRY C
WHERE Y.COUNTRY_CODE = C.COUNTRY_CODE
AND CONTINENT = 'EUROPE';

SELECT CITY_NAME, COUNTRY_NAME, POPULATION, COUNTRY_CODE
FROM EUROPEAN_CITIES
WHERE POPULATION > 1500000;

SELECT CITY_NAME, COUNTRY_NAME, Y.POPULATION, Y.COUNTRY_CODE
FROM CITY Y, COUNTRY C
WHERE Y.COUNTRY_CODE = C.COUNTRY_CODE
AND CONTINENT = 'EUROPE'
AND Y.POPULATION > 1500000;

/* QUESTION 3 */
/*1*/
/* GRANT SELECT ON CITY TO BARTON; */

/*2*/
/* GRANT INSERT ON COUNTRY_LANGUAGE TO KENT, ROGERS;
   GRANT INSERT ON CITY TO KENT, ROGERS; */

/*3*/
/* GRANT UPDATE ON CITY TO BANNER, PARKER; */

/*4*/
/* GRANT SELECT ON COUNTRY TO BARTON, KENT, ROGERS, BANNER, PARKER, WAYNE; */

/*5*/
/* GRANT DELETE ON COUNTRY TO WAYNE;
   GRANT INSERT ON COUNTRY TO WAYNE; */

/*6*/
/* GRANT INDEX ON CITY TO BANNER; */

/*7*/
/* GRANT ALTER ON COUNTRY_LANGUAGE TO BANNER, WAYNE; */

/*8*/
/* GRANT ALL ON CITY TO WAYNE;
   GRANT ALL ON COUNTRY TO WAYNE; */

/* QUESTION 4 */
/* REVOKE UPDATE FROM BANNER;
   REVOKE SELECT FROM BANNER;
   REVOKE INDEX FROM BANNER; */

/* QUESTION 5 */
CREATE INDEX COUNTRY_INDEX ON COUNTRY(COUNTRY_NAME, CONTINENT);

/* QUESTION 6 */
ALTER TABLE CITY
ADD FOREIGN KEY (COUNTRY_CODE) REFERENCES COUNTRY(COUNTRY_CODE);

/* QUESTION 7 */
ALTER TABLE COUNTRY_LANGUAGE
ADD CHECK (IS_OFFICIAL IN ('T', 'F'));

/* QUESTION 8 */

DELIMITER //

CREATE PROCEDURE POPULATION_SORTER(IN I_POP INT)
BEGIN
	DECLARE CI_NAME CHAR(35);
    DECLARE CO_NAME CHAR(52);
    DECLARE CONT enum('Asia','Europe','North America','Africa','Oceania','Antarctica','South America');
    DECLARE FINISHED INT DEFAULT 0;
    
    DECLARE POP_SORT CURSOR FOR
    SELECT CITY_NAME, COUNTRY_NAME, CONTINENT
    FROM CITY Y, COUNTRY C
    WHERE Y.COUNTRY_CODE = C.COUNTRY_CODE
    AND Y.POPULATION >= I_POP;
    
    DECLARE CONTINUE HANDLER FOR NOT FOUND
    SET FINISHED = 1;
    
    CALL TEMPORARY_TABLE();
    
    OPEN POP_SORT;
    
    POP_LOOP: LOOP
		FETCH POP_SORT INTO CI_NAME, CO_NAME, CONT;
        IF FINISHED = 1 THEN LEAVE POP_LOOP;
        END IF;
        INSERT INTO TEMP_TABLE SELECT CI_NAME, CO_NAME, CONT;
        END LOOP POP_LOOP;
        
        CLOSE POP_SORT;
        
        SELECT * FROM TEMP_TABLE;
    
END//

CREATE PROCEDURE TEMPORARY_TABLE()
	BEGIN
		DROP TABLE IF EXISTS TEMP_TABLE;
        CREATE TEMPORARY TABLE TEMP_TABLE
        (CITY_NAME CHAR(35),
        COUNTRY_NAME CHAR(52),
        CONTINENT ENUM('Asia','Europe','North America','Africa','Oceania','Antarctica','South America'));
END//

DELIMITER ;

/* QUESTION 9 */
/* call world.POPULATION_SORTER(); */