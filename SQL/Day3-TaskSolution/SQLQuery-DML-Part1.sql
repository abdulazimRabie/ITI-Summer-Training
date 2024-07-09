use World

select * from city
select * from Country
select * from CountryLanguage 

-- 1
select * from Country

-- 2
select distinct [Language] from CountryLanguage

-- 3
select [Name] as 'Country' from Country
where [Continent] = 'Africa'

-- 4
select [Name] as 'Country' from Country
where population > 2000000

-- 5
select [Name] as 'Country' from Country
where IndepYear between 1920 and 1990

-- 6
select [Name] as 'Country' from Country
where IndepYear is null

-- 7
select [Name] as 'Country' from Country
where GovernmentForm = 'Republic'

-- 8
select [Name] as 'Country' from Country
where Continent = 'Asia' and Population > 100000000

-- 9
select Code, [Name] as 'Country Code' from Country
where Code in (
	select CountryCode from  CountryLanguage
	where [Language] = 'Spanish' and IsOfficial = 1
)

-- 10
select CountryCode, count(*) from CountryLanguage
where IsOfficial = 1
group by CountryCode
having count(*) > 1

-- 11
select sum(cast(Population as bigint)) as 'people on earth' from Country

-- 12
select Continent , count(*) as 'Countries_no', sum( cast (Population as bigint)) as 'Total_Population'
from Country
group by Continent

-- 13 : inserting my country
insert into Country(Code, [Name], Continent, Region, SurfaceArea, IndepYear, [Population], LifeExpectancy, GNP, GNPOld, LocalName, GovernmentForm, HeadOfState, Capital, Code2)
values ('ABD', 'Abdulazim', 'Africa', 'Middle east', 123, 2003, 102, 35.5, null, null, 'Abdu', 'Republic', 'Abdulazim', '1', 'AB')

insert into CountryLanguage (CountryCode, [Language], IsOfficial, [Percentage])
values ('ABD', 'Arabic', '1', 33)

insert into City (ID, [Name], CountryCode, District, [Population])
values (9999, 'Rabie', 'IDN', 'Aboomar', 32)

-- 14
update Country
set	LifeExpectancy += 5
where Code = 'ABD'

select * from Country
where Code = 'ABD'

-- 15
delete from Country
where Code = 'ABD'
-- It Causes an error because the code of the country is reference in other tables
-- So, SQL Serer prevent you from deleting recods contain refernece values

