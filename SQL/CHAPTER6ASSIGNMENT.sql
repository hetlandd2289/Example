/* AUTHOR: DRAKE HETLAND
DATE: 11/8/2020
DESCRIPTION: ASSIGNMENT PRACTICING CONCEPTS DISCUSSED IN CHAPTER 6 */

USE COLONIAL_ADVENTURE_TOURS;

DROP TABLE PADDLING;

/* QUESTION 1 */
CREATE TABLE PADDLING
(TRIP_ID DECIMAL(3) PRIMARY KEY,
TRIP_NAME CHAR(75),
STATE CHAR(2),
DISTANCE DECIMAL(4,0),
MAX_GRP_SIZE DECIMAL(4,0),
SEASON CHAR(20));

/* QUESTION 2 */
INSERT INTO PADDLING
SELECT TRIP_ID, TRIP_NAME, STATE, DISTANCE, MAX_GRP_SIZE, SEASON
FROM TRIP
WHERE TYPE LIKE '%PADDLING%';

/* QUESTION 3 */
/* ALTER TABLE TRIP
MODIFY MAX_GRP_SIZE DECIMAL(6,0);

ALTER TABLE PADDLING
MODIFY MAX_GRP_SIZE DECIMAL(6,0); */

UPDATE PADDLING
SET MAX_GRP_SIZE = MAX_GRP_SIZE + 2
WHERE STATE = 'CT';

/* OR
UPDATE PADDLING
SET MAX_GRP_SIZE =+ 2
WHERE STATE = 'CT'; */

/* QUESTION 4 */
INSERT INTO PADDLING
VALUES
(43, 'Lake Champlain Tour', 'VT', 16, 12, 'Summer');

/* QUESTION 5 */
DELETE  FROM PADDLING
WHERE TRIP_ID = 23;

/* QUESTION 6 */
UPDATE PADDLING 
SET DISTANCE = NULL 
WHERE TRIP_NAME = 'Pontook Reservoir Tour';

/* QUESTION 7 */
ALTER TABLE PADDLING
ADD DIFFICULTY_LEVEL CHAR(3);

UPDATE PADDLING
SET DIFFICULTY_LEVEL = 'MOD';

/* QUESTION 8 */
UPDATE PADDLING
SET DIFFICULTY_LEVEL = 'HRD'
WHERE TRIP_NAME = 'Lake Champlain Tour';

/* QUESTION 9 */
ALTER TABLE PADDLING
MODIFY SEASON CHAR(25);

/* QUESTION 10 */
ALTER TABLE PADDLING
MODIFY DIFFICULTY_LEVEL CHAR(3) NOT NULL;

/* QUESTION 11 */
DROP TABLE PADDLING;