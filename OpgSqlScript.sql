select * from Cameras


create table Cameras(
	VideoId  varchar(100) primary key,
	CampaignId varchar(100),
	CameraId varchar(100),
	VideoUploadBeginTime DateTime,
	VideoUploadEndTime DateTime,
	VideoUrl nvarchar(max),
	DataArriveTime DateTime
)

delete Cameras

select count(*) from Cameras


create table PersonDetails(
	Id  varchar(100) primary key,
	MachineName varchar(100) ,
	FaceId  varchar(100) ,
	VideoId  varchar(100) ,
	ImageId varchar(100),
	[Name]  varchar(100) ,
	Age float,
	Confidence float,
	Gender  nvarchar(10) ,
	FacialHair varchar(100),
	Glasses varchar(100),
	Smile varchar(100),
	MonitorTime DateTime,
	UsedSubKey varchar(100)
)

select * from PersonDetails 
where Gender = 'female'
order by MonitorTime desc
select * from PersonDetails 
--where Gender = 'female'
order by MonitorTime desc


select count(*) from PersonDetails

drop table PersonDetails

delete PersonDetails


create table Images(
	Id  varchar(100) primary key,
	CampaignId  varchar(100) ,
	CameraId  varchar(100) ,
	VideoId  varchar(100) ,
	SentTime DateTime
)

select * from Images order by SentTime desc

delete Images


create table ImageForNames(
	Id  varchar(100) primary key,
	[name]  varchar(100) ,
	SentTime DateTime
)

select * from ImageForNames



create table PersonGroup(
	Id  varchar(100) primary key,
	[name]  varchar(100) ,
	UserData varchar(100) ,
	SentTime DateTime
)

select * from PersonGroup
delete PersonGroup

insert into PersonGroup values('f509d531-9426-417e-959d-103e917cddb3', 'jiwag', '9b55e3b4-2484-443f-8f0f-9e086ecbe93e', GETDATE());




create table CameraRegister(
    Id  varchar(100) primary key,
	MachineName  varchar(100) ,
	LocationAddr varchar(100) ,
	UpdatedTime DateTime ,
	CreatedTime DateTime
)

select * from CameraRegister
delete CameraRegister

drop table CameraRegister


create table AccountRegister(
	Id  varchar(100) primary key,
	[Name]  nvarchar(100) ,
	Content nvarchar(max) ,
	UpdatedTime DateTime ,
	CreatedTime DateTime
)

select * from AccountRegister
delete AccountRegister

drop table AccountRegister