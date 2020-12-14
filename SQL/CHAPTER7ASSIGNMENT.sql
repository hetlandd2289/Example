/* AUTHOR: DRAKE HETLAND
DATE: 12-3-2020
DESCRIPTION: ASSIGNMENT PRACTICING CONCEPTS COVERED IN CHAPTER 7 */

USE COLONIAL_ADVENTURE_TOURS;
DROP VIEW IF EXISTS MAINE_TRIPS;
DROP VIEW IF EXISTS RESERVATION_CUSTOMER;
DROP VIEW IF EXISTS TRIP_INVENTORY;
/*DROP INDEX TRIP_INDEX1 ON TRIP;
DROP INDEX TRIP_INDEX2 ON TRIP;
DROP INDEX TRIP_INDEX3 ON CUSTOMER;

/* QUESTION 1 */
#1
CREATE VIEW MAINE_TRIPS AS 
SELECT TRIP_ID, TRIP_NAME, START_LOCATION, DISTANCE, MAX_GRP_SIZE, SEASON, TYPE
FROM TRIP
WHERE STATE = 'ME';

#2
SELECT TRIP_ID, TRIP_NAME, DISTANCE
FROM MAINE_TRIPS
WHERE TYPE = 'BIKING';

#3
SELECT TRIP_ID, TRIP_NAME, START_LOCATION, DISTANCE, MAX_GRP_SIZE, SEASON, TYPE
FROM TRIP
WHERE STATE = 'ME'
AND TYPE = 'BIKING';

#4
/* IT SHOULD NOT CAUSE ANY ERRORS AS THE PRIMARY KEY IS INCLUDED AND ALL OTHER COLLUMNS ARE NULLABLE */

/* QUESTION 2 */
#1
CREATE VIEW RESERVATION_CUSTOMER AS 
SELECT RESERVATION_ID, TRIP_ID, TRIP_DATE, C.CUSTOMER_NUM, LAST_NAME, FIRST_NAME, PHONE
FROM CUSTOMER C, RESERVATION R
WHERE C.CUSTOMER_NUM = R.CUSTOMER_NUM;

#2
SELECT RESERVATION_ID, TRIP_ID, TRIP_DATE, LAST_NAME
FROM RESERVATION_CUSTOMER
WHERE TRIP_DATE = '2016-9-11';

#3
SELECT RESERVATION_ID, TRIP_ID, TRIP_DATE, C.CUSTOMER_NUM, LAST_NAME, FIRST_NAME, PHONE
FROM CUSTOMER C, RESERVATION R
WHERE C.CUSTOMER_NUM = R.CUSTOMER_NUM
AND TRIP_DATE = '2016-9-11';

#4
/* THIS WOULD CAUSE ERRORS AS THE PRIMARY KEY OF THE RESERVATION TABLE IS NOT INCLUDED */

/* QUESTION 3 */
#1
 CREATE VIEW TRIP_INVENTORY (STATE, UNITS) AS
 SELECT STATE, COUNT(TRIP_ID)
 FROM TRIP
 GROUP BY STATE
 ORDER BY STATE;
 
 #2
 SELECT STATE, UNITS
 FROM TRIP_INVENTORY
 WHERE UNITS > 10;
 
 #3
 SELECT STATE, COUNT(TRIP_ID)
 FROM TRIP
 GROUP BY STATE
 ORDER BY STATE
 AND COUNT(TRIP_ID) > 10;
 
 #4
 /* UPDATING THROUGH THIS VIEW WOULD CAUSE PROBLEMS BECAUSE THE PRIMARY KEY IS NOT INCLUDED */

/* QUESTION 4 */
/* #1
GRANT SELECT ON TRIP TO Rodriquez;

#2
GRANT INSERT ON RESERVATIONS TO Gomez, Liston;

#3
GRANT INSETR, DELETE ON TRIP TO ANDREWS, ZIMMER;

#4
GRANT SELECT ON TRIP TO ALL;

#5
GRANT INSERT, DELETE ON GUIDES TO GOLDEN;

#6
GRANT INDEX ON TRIP TO ANDREWS;

#7
GRANT ALTER ON CUSTOMER TO ANDREWS, GOLDEN;

#8
GRANT ALL ON TRIP, GUIDE, TRIP_GUIDES TO GOLDEN;
*/

/* QUESTION 5 */
/* REVOKE ALL FROM ANDREWS; */

/* QUESTION 6 */
#1
CREATE INDEX TRIP_INDEX1 ON TRIP(TRIP_NAME);

#2
CREATE INDEX TRIP_INDEX2 ON TRIP(TYPE);

#3
CREATE INDEX TRIP_INDEX3 ON CUSTOMER(LAST_NAME, FIRST_NAME);

/* QUESTION 7 */
DROP INDEX TRIP_INDEX3 ON CUSTOMER;

/* QUESTION 8 */
#1
/*SELECT COLUMN_NAME, DATA_TYPE
FROM DBA_TAB_COLUMNS
WHERE TABLE = GUIDE;*/

#2
/*SELECT TABLE_NAME
FROM DBA_TAB_TABLES
WHERE COLUMN = TRIP_ID;*/

#3
/*SELECT TABLE_NAME, COLUMNN_NAME, DATA_TYPE
FROM DBA_TAB_COLUMNS
WHERE COLUMN_NAME = TRIP_ID, TRIP_NAME, TYPE
ORDER BY (COLUMN_NAME, TABLE_NAME);*/

/* QUESTION 9 */
ALTER TABLE RESERVATION
ADD FOREIGN KEY (CUSTOMER_NUM) REFERENCES CUSTOMER;

/* QUESTION 10 */
ALTER TABLE TRIP
ADD CHECK (TYPE IN ('BIKING', 'HIKING', 'PADDLING'));

/* QUESTION 11 */



