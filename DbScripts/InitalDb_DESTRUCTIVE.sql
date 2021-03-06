﻿USE [Logging]
GO

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logger_entries') 
DROP TABLE [dbo].[logger_entries];
CREATE TABLE [dbo].[logger_entries] (
    [id] [int] NOT NULL IDENTITY,
    [logger_operation_id] [int] NOT NULL,
    [event_id] [int],
    [priority] [int],
    [severity] [nvarchar](50),
    [title] [nvarchar](250),
    [message] [text] NOT NULL,
    [timestamp] [datetime] NOT NULL,
    [machine_name] [nvarchar](250),
    [process_id] [nvarchar](255),
    [process_name] [nvarchar](512),
    [thread_name] [nvarchar](512),
    [win32_thread] [nvarchar](128),
    CONSTRAINT [PK_dbo.logger_entries] PRIMARY KEY ([id])
)
CREATE INDEX [IX_logger_operation_id] ON [dbo].[logger_entries]([logger_operation_id])

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logger_operations') 
DROP TABLE [dbo].[logger_operations];
CREATE TABLE [dbo].[logger_operations] (
    [id] [int] NOT NULL IDENTITY,
    [title] [nvarchar](150),
    [logger_thread_id] [int],
    [description] [nvarchar](500),
    [created] [datetime],
    CONSTRAINT [PK_dbo.logger_operations] PRIMARY KEY ([id])
)
CREATE INDEX [IX_logger_thread_id] ON [dbo].[logger_operations]([logger_thread_id])

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logger_threads') 
DROP TABLE [dbo].[logger_threads];
CREATE TABLE [dbo].[logger_threads] (
    [id] [int] NOT NULL IDENTITY,
    [title] [nvarchar](250),
    [log_status_id] [int],
    [parent_id] [int],
    [guid] [nvarchar](120) NOT NULL,
    [created] [datetime],
    [updated] [datetime],
    CONSTRAINT [PK_dbo.logger_threads] PRIMARY KEY ([id])
)
CREATE INDEX [IX_log_status_id] ON [dbo].[logger_threads]([log_status_id])

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'logger_thread_statuses') 
DROP TABLE [dbo].[logger_thread_statuses];
CREATE TABLE [dbo].[logger_thread_statuses] (
    [id] [int] NOT NULL IDENTITY,
    [code] [nvarchar](150),
    [name] [nvarchar](250),
    CONSTRAINT [PK_dbo.logger_thread_statuses] PRIMARY KEY ([id])
)
 -- INSERT SEED DATA
INSERT INTO [dbo].[logger_thread_statuses]
           ([code]
           ,[name])
     VALUES
           ('THREAD_STATUS_OPEN'
           ,'Open'),
           ('THREAD_STATUS_RUN'
           ,'Running'),
           ('THREAD_STATUS_DONE'
           ,'Done');

ALTER TABLE [dbo].[logger_entries] ADD CONSTRAINT [FK_dbo.logger_entries_dbo.logger_operations_logger_operation_id] FOREIGN KEY ([logger_operation_id]) REFERENCES [dbo].[logger_operations] ([id]) ON DELETE CASCADE
ALTER TABLE [dbo].[logger_operations] ADD CONSTRAINT [FK_dbo.logger_operations_dbo.logger_threads_logger_thread_id] FOREIGN KEY ([logger_thread_id]) REFERENCES [dbo].[logger_threads] ([id])
ALTER TABLE [dbo].[logger_threads] ADD CONSTRAINT [FK_dbo.logger_threads_dbo.logger_thread_statuses_log_status_id] FOREIGN KEY ([log_status_id]) REFERENCES [dbo].[logger_thread_statuses] ([id])

IF EXISTS 
        (SELECT 
             TABLE_NAME 
         FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '__MigrationHistory') 
DROP TABLE [dbo].[__MigrationHistory];
CREATE TABLE [dbo].[__MigrationHistory] (
    [MigrationId] [nvarchar](150) NOT NULL,
    [ContextKey] [nvarchar](300) NOT NULL,
    [Model] [varbinary](max) NOT NULL,
    [ProductVersion] [nvarchar](32) NOT NULL,
    CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY ([MigrationId], [ContextKey])
)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201509081832431_InitialCreate', N'Logging',  0x1F8B0800000000000400ED5CDD6EE3B815BE2FD077107459CC5AB1830176027B17532759049D4C06E364DBBB80916887A844A922954D50F4C97AD147EA2B94D40F4D89A444CA729A590CE662C634F99DC3C3C37378C8CFF3DF7FFF67F9F373127B4F302728C52B7F3E3BF13D88C3344278B7F20BBAFDE147FFE79FFEF887E545943C7BBF36FD4E793F36129395FF4869761604247C840920B30485794AD22D9D85691280280D1627271F82F93C800CC267589EB7FC5A608A12587E601FD7290E61460B105FA7118C49DDCEBED994A8DE679040928110AEFC0D4A12B245E4916938FB94EE76FCEF72D8EC1788610E288C7CEF638C00D36D03E3ADEF018C530A28D3FCEC8EC00DCD53BCDB64AC01C4B72F1964FDB62026B09ED1D9BEBBEDE44E167C72C17E6003151684A68923E0FCB4B656D01D3ECAE6BEB026B3E705B33B7DE1B32E6DBAF2B90561CE9AF317DFEBCA3B5BC739EF6B67F59984F5CE338F7827FC88B91BFFF3CE5B17312D72B8C2B0A039603DBE140F310AFF025F6ED3BF43BCC2451CCBF3603361DFB51A58D3973CCD604E5FBEC26D3DBB2BE60A417B5CD01D28864963AA495F617ABAF0BDCF4C387888A17013C9401B9AE65058E00BA014E69863C0D2D08AF48EACCA6237191FCEE08645F7C35D3C31B10A48FF982F394AF3525587411BC842863488ED29B6BCBE770D9E3F41BCA38F2BFF3D8B1097E819464D433D833B8C58786163685E0C4EE816D118F608594C22E51A1202767D724E3F7CF83020A8FEECB862B72C0A120A92AC117ECEFC88373A235D83906D35C83F1CDD60EC63C86CB6F734ADA4F7D3491A98D5FBF9620A677BCC21885E45D45F113E5D54F27A64CD173F8E91F5193CA15D194FFAA38DEF7D8571F92F16A4B32A59CA31FC5EE97F99A7C9D7346EA78D6EB7FB4D5AE421B7613ADCF716E43B48DB535806FB2C6591BB24FD26C95F02EF7B0EB3CA6143317A3E49C8A9D6A6DA328E19EE1C92304759E5223DF96A0A35D74CBFF200DA8DE66E7B946F1604C9B17668B3EB6C7668B39BDD26D0C436A3FE7B01ED01DD09E8FB19628CA1F30441A6516F920853817D0F2F938497694E34CCFA1BA66F415C4FCF20773F72FF52A0FEB46F3723C703A26D68EA0CBBCBA229229AD89A7D41EDC0A0A00F6B0311644C5CAB5CA56722B50CDD98EE5C8C5D0D31CEDC7FB230D7A83A61B0AB20BF873CAB90B766F638FA81EA3885A2D5F639FACED10782E19D66B3733E129286A8545E33359DE26D0B5DE0C873DCFFD51A756DC4968BED0F94B11DC1D45CF97F5216C35E9430985E54B3026D8127B3D95C91C97619E429118178CD9697ED5B84A9BA25110E51066237F53A30967B9B2FA510D8FDE61C6610F36DE9B626369AB48E14AA4A427227100D197019481E68E39886A4DAEF2A43C7EEAE9F482588AB570E25733BEF9FDA19FBB57A354FEC5F074B376C15CEFF474FD4D7ACFDDE3170C5D4758EFA21C3D50707CA646B6F9F7797647983CF610C29F43E86D503D01A9010446AE664E9269ACC7B7BE7F36ACEDBBB76F6BEDB7A1E7905F7ADF23E1B43D908984BBAB043D2F903FF023E53CDF1F88EC0FA844CEAE351D7EB38F00652FD5DCFFEBCA17369C583755872956580937CD70A521CD90C784D3876006B8E13BD884DA70EAEB4667A70EDD1511A6579DAECBA99FBB14D5840B1A4E2C3EE073503B8C16841DB6AD61635D5E32673DA1C35DC0F1BCA5C652F1FB4E5C0F1C2769546DBD070516B32A1458E74CE92CA1C45C819B45E7F627458991EFB35959688B87BFA4750F13F1A9E4860208A2CAF4196B1E02C1147EA166F53B146D63F6CDCC9134985118444C3A110DA0A49ACE8073BD8F9B6AAE62F514EE839A0E001F01A7A1D254A3725BF18E269234E9742D4D56C026C338AFFBB7EC27764746812760D7AC9A69DF0DC5F5E7B689D4D33BA24F78018E49A8B96751A1709AE3E234DD2378FD69C1864B0B8FCFA3E159EEC862EF8153226E48D8E407BD2858C9489567BA43D13434622A2D51EA9BE68976168D5648F219814324AD234BAE82268116D7D44B3834E3231A2A557F5C53D06EA7576FFE209F6437BF5CA66674F90080E3A3857ED641643CB7655DE73856B311564BCDFF817F7547BFA2BE1824E78500EEE4A74520AA276C8730888521E3A524C34E666EBB8D883709CD838C506EFDE2668826BED686EBAB5DEE865D048FEC21E4F3C76C95861D3F8C6BCB539721EC955F5A7706B3F350D7FD34EBABF79ED78E83DA90A29C7282D9E795B21BA6C7584AA1E7F65985DE186E0EADB261CF1B22BE3144DE39BDC23C6E27CC28DA297E1B85D4C20C7D934D58361CB1D52F58AB10F413D2F980E0A47F502A514EC7611D24549D829FD96751936FC4302A52EABBAF81E33CD138A784DB67921142633DE61B6F947BC8E119BEFBEC335C068CB0EA4D56BB4BF38E1DCD0D62F0FDECEAF000242A25853C61A7E0A30E2555D75D9E157F53D0F0671C30EBE9B3B525EB4E59E244FB9C1BDC2117C5EF9FF2CC79F79577FBBD740BCF36E72B6FA67DE89F72F6795F6D5A2A4C71EC3E6E53EEB30F64740900E7F1F3F813C7C04B9C2E07783A532574B8BB970074DDAECFCEAEEDDD1EAB44BB3E7498E8EA1D9B78BC669672A5790BDC8EFC7220F6A5DD2DB1D175D2E2CA7856ED7983DD82553BE0F7B34A7FCF711088737E6DCDD5DD57A6F546815E34D71D5469748E5781B629AF334C5C9DA1C390EF6372D27E3F7EB6C236263A77473F6B4FDE043DC4CAAF846E7DE5D3110DF4BFEAFA3CD4739A90A53B4C9BE47F4752D37EE5BF5F850226C4E155D0F3F60BC2E83B1797A3E9C42A8C73F8007793027D1782560E39DDE58FEA195BC812BADB7CE33745C5B2B7F915ED90FE1291EEC35AFE72F7D8F115A9719B8A77FE39CC0510B3C29354F4B93184F479C82A7FA7ADE66A203183DADFFB9FDD5187C2A11C370FFACB90F1B20E7555787ECC0F490322FA812723D79A8E7DA0C11F86CF87B3D5285C96D0537F17680E5D723921A88539331010765D7895063ECB7C51A6CCFDA92C4D7933C4D4F76DF180DD0713AFD89A1E7B9FD9B62F68D9A92394319D8594721EBA92F312CA44BFFF1134B2F04EDF610FCBF81C2306C0573D1E70A6FD326C174346ABA285C240A58010B3EE6146D41486BA64DF943B75F415CB02E17C9038CAEF04D41B382B229C3E4216E1983E7A63EF92523B1ADF3F2A6BC8522534C81A989780D7E83FF5CA038127A5FAA45A9098227BDBAD2E56B4979C5BB7B11489F536C09549B4FE4EA5B98643103233778039EE018DDEE08FC0477207C691ED4CC20C30BD136FBF21C815D0E125263ECC7B38FCC87A3E4F9A7FF01FB2698DCFF4C0000 , N'6.1.3-40302')

