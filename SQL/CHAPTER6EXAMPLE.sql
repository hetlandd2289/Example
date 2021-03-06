USE TAL_DISTRIBUTORS;

/* QUESTION 1 */
#A
CREATE VIEW MAJOR_CUSTOMER AS 
SELECT CUSTOMER_NUM, CUSTOMER_NAME, BALANCE, CREDIT_LIMIT, REP_NUM
FROM CUSTOMER
WHERE CREDIT_LIMIT <= 10000;

#B
SELECT CUSTOMER_NUM, CUSTOMER_NAME
FROM MAJOR_CUSTOMER
WHERE BALANCE > CREDIT_LIMIT;

#C
SELECT CUSTOMER_NUM, CUSTOMER_NAME
FROM MAJOR_CUSTOMER
WHERE BALANCE > CREDIT_LIMIT
AND CREDIT_LIMIT <= 10000;

/* QUESTION 6 */
#A
CREATE INDEX ITEM_INDEX1 ON ORDER_LINE(ITEM_NUM);

#B
CREATE INDEX ITEM_INDEX2 ON ITEM(CATEGORY DESC, STOREHOUSE);

/* QUESTION 9 */
ALTER TABLE ORDER_LINE
ADD FOREIGN KEY (ORDER_NUM) REFERENCES ORDERS(ORDER_NUM);

/* QUESTION 1 EXAMPLE */
#A
CREATE VIEW SMALL_CONDO AS
SELECT LOCATION_NUM, UNIT_NUM, BDRMS, BATHS, CONDO_FEE, OWNER_NUM
FROM CONDO_UNIT
WHERE SQR_FT < 1100;

#B
SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE
FROM SMALL_CONDO
WHERE CONDO_FEE >= 400;

#C
SELECT LOCATION_NUM, UNIT_NUM, CONDO_FEE
FROM CONDO_UNIT
WHERE CONDO_FEE >= 400
AND SQR_FT < 1100;

/* QUESTION 2 EXAMPLE */
#A
CREATE VIEW CONDO_OWNERS AS 
SELECT LOCATION_NUM, UNIT_NUM, SQR_FT, BDRMS, BATHS, CONDO_FEE, LAST_NAME
FROM CONDO_UNIT C, OWNER O
WHERE U.OWNER_NUM = O.OWNER_NUM
AND BDRMS = 3;

/* QUESTION 4 EXAMPLE */
#A
GRANT SELECT ON CONDO_UNIT TO OLIVER;

#B
GRANT INSERT ON OWNER TO CRANDALL, PEREZ;
GRANT INSERT ON CONDO_UNIT TO CRANDALL, PEREZ;

/* QUESTION 6 EXAMPLE */ 
#C 
CREATE INDEX OWNER_INDEX3 ON OWNER(STATE DESC, CITY);


