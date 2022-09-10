--◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻ LAB5 ◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻◻
--lab5
--i) create tables
create table STUDENT (regno varchar(20), name varchar(50), major varchar(20),bdate date, PRIMARY KEY (regno));
create table COURSE (course# int, cname varchar(30), dept varchar(30),PRIMARY KEY (course#));
create table TEXT (book_isbn int, booktitle varchar(50), publisher varchar(50), author varchar(50),PRIMARY KEY(book_isbn));
create table ENROLL (regno varchar(20), course# int, FOREIGN KEY (regno) REFERENCES STUDENT(regno), FOREIGN KEY (course#) REFERENCES COURSE(course#));
create table BOOK_ADOPTION (course# int, sem int, book_isbn int,PRIMARY KEY(course#,book_isbn),FOREIGN KEY (course#) REFERENCES COURSE(course#),FOREIGN KEY (book_isbn) REFERENCES TEXT(book_isbn));

-- ii) insert tuples
insert into STUDENT values(200911214,'Parth','IT','18-MAR-2002');
insert into STUDENT values(200911156,'Arihant','IT','18-JUN-2002');
insert into STUDENT values(200911213,'Riddhi','IT','18-MAR-2002');
insert into STUDENT values(200911270,'Shreeyanka','IT','27-JUN-2002');
insert into STUDENT values(200911188,'Anoushka','IT','18-MAR-2002');
insert into COURSE values(1,'DBMS','ICT');
insert into COURSE values(2,'EMW','EEE');
insert into COURSE values(3,'SE','ICT');
insert into COURSE values(4,'BME','MECH');
insert into COURSE values(5,'ES','ICT');
insert into ENROLL values(200911214,1);
insert into ENROLL values(200911213,2);
insert into ENROLL values(200911156,3);
insert into ENROLL values(200911270,4);
insert into ENROLL values(200911188,5);
insert into TEXT values(0763676187,'The Knife of Never Letting Go','CandleWick Press','Patrick Ness');
insert into TEXT values(0300181671,'Ferdydurke','Yale University Press','Witold Gombrowicz');
insert into TEXT values(0679735771,'American Psycho','Knopf Doubleday Publishing Group','Bret Easton Ellis');
insert into TEXT values(1732172358,'To Dream the Blackbane: A Novel of the Anomaly','Between the Lines Publishing','Richard J. O\’Brien');
insert into TEXT values(039480001,'The Cat in the Hat','Random House Books for Young Readers','Dr. Seuss');
insert into BOOK_ADOPTION values(1,5,0763676187);
insert into BOOK_ADOPTION values(2,5,0300181671);
insert into BOOK_ADOPTION values(1,5,0300181671);
insert into BOOK_ADOPTION values(3,5,0679735771);
insert into BOOK_ADOPTION values(4,2,1732172358);
insert into BOOK_ADOPTION values(5,5,039480001);
-- iii) a. List the courses which uses more than 1 text book.
select cname from COURSE
where course# in (select course# from BOOK_ADOPTION group by course# having count(book_isbn)>1);
-- another way using natural join
select cname from COURSE NATURAL JOIN BOOK_ADOPTION
group by course#,cname having count(book_isbn)>1;
-- iv) b. List the departments whose all course text books are published by a particular publisher.
select distinct dept from COURSE
where course# in (select course# from BOOK_ADOPTION where book_isbn in (select book_isbn from TEXT where publisher = 'CandleWick Press'));