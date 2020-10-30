/* AUTHOR: DRAKE HETLAND
DATE: 10/27/2020
DESCRIPTION: ASSIGNMENT PRACTICING CONCEPTS DISCUSSED IN CHAPTER 5 */

USE SOLMARIS;

/* QUESTION 1 */
SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE, C.OWNER_NUM, FIRST_NAME, LAST_NAME
FROM OWNER O, CONDO_UNIT C
WHERE C.OWNER_NUM = O.OWNER_NUM;

/* QUESTION 2 */
SELECT CONDO_ID, DESCRIPTION, SERVICE_STATUS 
FROM SERVICE_REQUEST R, SERVICE_CATEGORY C 
WHERE R.CATEGORY_NUM = C.CATEGORY_NUM 
AND CATEGORY_DESCRIPTION = 'JANITORIAL';

/* QUESTION 3 */
SELECT R.CONDO_ID, LOCATION_NUM, UNIT_NUM, EST_HOURS, SPENT_HOURS, O.OWNER_NUM, LAST_NAME
FROM SERVICE_REQUEST R, OWNER O, SERVICE_CATEGORY C, CONDO_UNIT U
WHERE R.CATEGORY_NUM = C.CATEGORY_NUM
AND R.CONDO_ID = U.CONDO_ID
AND U.OWNER_NUM = O.OWNER_NUM
AND CATEGORY_DESCRIPTION = 'JANITORIAL';

/* QUESTION 4 */
SELECT FIRST_NAME, LAST_NAME
FROM OWNER O, CONDO_UNIT U
WHERE U.OWNER_NUM  = O.OWNER_NUM
AND BDRMS IN (SELECT BDRMS FROM CONDO_UNIT WHERE BDRMS = 3);

/* QUESTION 5 */
SELECT FIRST_NAME, LAST_NAME
FROM OWNER O, CONDO_UNIT U
WHERE EXISTS
(SELECT BDRMS FROM CONDO_UNIT WHERE U.OWNER_NUM = O.OWNER_NUM AND BDRMS = 3);

/* QUESTION 6 */
SELECT U.UNIT_NUM, C.UNIT_NUM
FROM CONDO_UNIT U, CONDO_UNIT C
WHERE U.SQR_FT = C.SQR_FT
AND U.UNIT_NUM <> C.UNIT_NUM ORDER BY U.UNIT_NUM, C.UNIT_NUM;
/* AND U.UNIT_NUM < C.UNIT_NUM
THIS IS NESSECARY!!!!! */

/* QUESTION 7 */
SELECT SQR_FT, O.OWNER_NUM, LAST_NAME, FIRST_NAME
FROM CONDO_UNIT U, OWNER O
WHERE U.OWNER_NUM = O.OWNER_NUM
AND LOCATION_NUM = 1;

/* QUESTION 8 */
SELECT SQR_FT, O.OWNER_NUM, LAST_NAME, FIRST_NAME
FROM CONDO_UNIT U, OWNER O
WHERE U.OWNER_NUM = O.OWNER_NUM
AND LOCATION_NUM = 1
AND BDRMS = 3;

/* QUESTION 9 */
/* SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE
FROM CONDO_UNIT U, OWNER O
WHERE U.OWNER_NUM = O.OWNER_NUM
AND CITY = 'BOWTON' OR BDRMS = 1; */

SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE
FROM CONDO_UNIT C, OWNER O
WHERE C.OWNER_NUM = O.OWNER_NUM
AND CITY = 'BOWTON' 
UNION
SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE
FROM CONDO_UNIT 
WHERE BDRMS = 1;
/* OR MEANS TO USE UNION

/* QUESTION 10 */
SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE
FROM CONDO_UNIT U, OWNER O
WHERE U.OWNER_NUM = O.OWNER_NUM
AND CITY = 'BOWTON' AND BDRMS = 1;

/* QUESTION 11 */
SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE
FROM CONDO_UNIT U, OWNER O
WHERE U.OWNER_NUM = O.OWNER_NUM
AND CITY = 'BOWTON' AND BDRMS <> 1;

/* QUESTION 12 */
/* SELECT R.SERVICE_ID, R.CONDO_ID
FROM SERVICE_REQUEST R, SERVICE_REQUEST S
WHERE R.EST_HOURS <= S.EST_HOURS
AND R.CATEGORY_NUM = 5; */

SELECT SERVICE_ID, CONDO_ID
FROM SERVICE_REQUEST
WHERE EST_HOURS > ANY
(SELECT EST_HOURS FROM SERVICE_REQUEST WHERE CATEGORY_NUM = 5);

/* SELECT SERVICE_ID, CONDO_ID
FROM SERVICE_REQUEST
WHERE EST_HOURS > 
(SELECT MIN(EST_HOURS) FROM SERVICE_REQUEST WHERE CATEGORY_NUM = 5); */

/* QUESTION 13 */
/* SELECT R.SERVICE_ID, R.CONDO_ID
FROM SERVICE_REQUEST R, SERVICE_REQUEST S
WHERE R.EST_HOURS < S.EST_HOURS
AND R.CATEGORY_NUM = 5; */

SELECT SERVICE_ID, CONDO_ID
FROM SERVICE_REQUEST
WHERE EST_HOURS > ALL
(SELECT EST_HOURS FROM SERVICE_REQUEST WHERE CATEGORY_NUM = 5);

/* SELECT SERVICE_ID, CONDO_ID
FROM SERVICE_REQUEST
WHERE EST_HOURS > 
(SELECT MAX(EST_HOURS) FROM SERVICE_REQUEST WHERE CATEGORY_NUM = 5); */

/* QUESTION 14 */
SELECT U.CONDO_ID, SQR_FT, OWNER_NUM, SERVICE_ID, EST_HOURS, SPENT_HOURS
FROM CONDO_UNIT U, SERVICE_REQUEST R
WHERE U.CONDO_ID = R.CONDO_ID
AND R.CATEGORY_NUM = 4;

/* QUESTION 15 */
SELECT U.CONDO_ID, SQR_FT, OWNER_NUM, SERVICE_ID, EST_HOURS, SPENT_HOURS
FROM CONDO_UNIT U, SERVICE_REQUEST R
WHERE U.CONDO_ID = R.CONDO_ID;

/* QUESTION 16 */
SELECT U.CONDO_ID, SQR_FT, OWNER_NUM, SERVICE_ID, EST_HOURS, SPENT_HOURS
FROM CONDO_UNIT U, SERVICE_REQUEST R
WHERE U.CONDO_ID = R.CONDO_ID
AND CATEGORY_NUM IN (SELECT CATEGORY_NUM FROM SERVICE_REQUEST WHERE CATEGORY_NUM = 4);
/* THE IN OPPERATOR ACCOMPLISHES THE SAME TASK AS THE AND, IT JUST TAKES MORE CODE. */