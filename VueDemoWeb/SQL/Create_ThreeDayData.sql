CREATE TABLE [dbo].[ThreeDayData] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CountryCode]  VARCHAR (10)   NULL,
    [AreaName]     NVARCHAR (50)  NULL,
    [ForecastDate] DATETIME       NULL,
    [Temperature]  NVARCHAR (250) NULL,
    [CreateDate]   DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'城市代碼', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ThreeDayData', @level2type = N'COLUMN', @level2name = N'CountryCode';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'區域名稱', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ThreeDayData', @level2type = N'COLUMN', @level2name = N'AreaName';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'預報時間', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ThreeDayData', @level2type = N'COLUMN', @level2name = N'ForecastDate';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'温度', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ThreeDayData', @level2type = N'COLUMN', @level2name = N'Temperature';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'建立時間', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ThreeDayData', @level2type = N'COLUMN', @level2name = N'CreateDate';

