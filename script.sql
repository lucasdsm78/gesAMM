USE [GSB_gesAMM]
GO
/****** Object:  Table [dbo].[Decision]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Decision](
	[dcs_id] [int] IDENTITY(1,1) NOT NULL,
	[dcs_libelle] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Decision] PRIMARY KEY CLUSTERED 
(
	[dcs_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etape]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etape](
	[etp_num] [int] IDENTITY(1,1) NOT NULL,
	[etp_libelle] [nvarchar](255) NOT NULL,
	[etp_norme] [nvarchar](255) NULL,
	[etp_date_norme] [date] NULL,
	[etp_user_id] [int] NULL,
 CONSTRAINT [PK_Etape] PRIMARY KEY CLUSTERED 
(
	[etp_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Famille]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Famille](
	[fam_code] [nvarchar](3) NOT NULL,
	[fam_libelle] [nvarchar](80) NOT NULL,
	[fam_nbMediAmm] [int] NULL,
 CONSTRAINT [PK_Famille] PRIMARY KEY CLUSTERED 
(
	[fam_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historique]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historique](
	[htq_id] [int] IDENTITY(1,1) NOT NULL,
	[htq_user] [int] NOT NULL,
	[htq_etp_num] [int] NOT NULL,
	[htq_date_maj] [datetime] NOT NULL,
	[htq_date_old] [date] NULL,
	[htq_date_new] [date] NULL,
	[htq_norme_old] [nvarchar](20) NULL,
	[htq_norme_new] [nvarchar](20) NULL,
 CONSTRAINT [PK_Historique] PRIMARY KEY CLUSTERED 
(
	[htq_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicament]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicament](
	[med_depotLegal] [nvarchar](10) NOT NULL,
	[med_nomCommercial] [nvarchar](25) NOT NULL,
	[med_composition] [nvarchar](255) NOT NULL,
	[med_effets] [nvarchar](255) NOT NULL,
	[med_contreIndications] [nvarchar](255) NOT NULL,
	[med_amm] [nvarchar](10) NULL,
	[med_derniereEtape] [int] NULL,
	[med_codeFamille] [nvarchar](3) NULL,
 CONSTRAINT [PK_Medicament] PRIMARY KEY CLUSTERED 
(
	[med_depotLegal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateurs]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateurs](
	[usr_id] [int] IDENTITY(1,1) NOT NULL,
	[usr_username] [nvarchar](255) NOT NULL,
	[usr_password] [text] NOT NULL,
 CONSTRAINT [PK_Utilisateurs] PRIMARY KEY CLUSTERED 
(
	[usr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Workflow]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Workflow](
	[wkf_date_decision] [date] NULL,
	[wkf_etp_num] [int] NOT NULL,
	[wkf_dcs_id] [int] NOT NULL,
	[wkf_med_id] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Workflow_1] PRIMARY KEY CLUSTERED 
(
	[wkf_etp_num] ASC,
	[wkf_med_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Decision] ON 

INSERT [dbo].[Decision] ([dcs_id], [dcs_libelle]) VALUES (1, N'Acceptée')
INSERT [dbo].[Decision] ([dcs_id], [dcs_libelle]) VALUES (2, N'Refusée')
SET IDENTITY_INSERT [dbo].[Decision] OFF
GO
SET IDENTITY_INSERT [dbo].[Etape] ON 

INSERT [dbo].[Etape] ([etp_num], [etp_libelle], [etp_norme], [etp_date_norme], [etp_user_id]) VALUES (1, N'Définition du protocole de validation', NULL, NULL, NULL)
INSERT [dbo].[Etape] ([etp_num], [etp_libelle], [etp_norme], [etp_date_norme], [etp_user_id]) VALUES (2, N'Pharmacologie expérimentale', NULL, NULL, NULL)
INSERT [dbo].[Etape] ([etp_num], [etp_libelle], [etp_norme], [etp_date_norme], [etp_user_id]) VALUES (3, N'Toxicologie', N'726/2004/CEE', CAST(N'2005-05-17' AS Date), 1)
INSERT [dbo].[Etape] ([etp_num], [etp_libelle], [etp_norme], [etp_date_norme], [etp_user_id]) VALUES (4, N'Pharmacocinétique', NULL, NULL, NULL)
INSERT [dbo].[Etape] ([etp_num], [etp_libelle], [etp_norme], [etp_date_norme], [etp_user_id]) VALUES (5, N'Expérimentation animale', N'180/2012/CEEEE', CAST(N'2012-01-05' AS Date), 1)
INSERT [dbo].[Etape] ([etp_num], [etp_libelle], [etp_norme], [etp_date_norme], [etp_user_id]) VALUES (6, N'Méthodes alternatives', NULL, NULL, NULL)
INSERT [dbo].[Etape] ([etp_num], [etp_libelle], [etp_norme], [etp_date_norme], [etp_user_id]) VALUES (7, N'Essais cliniques', N'457/2008/CEE', CAST(N'2008-03-15' AS Date), 1)
INSERT [dbo].[Etape] ([etp_num], [etp_libelle], [etp_norme], [etp_date_norme], [etp_user_id]) VALUES (8, N'Autorisation Mise sur le marché', N'665/2005/CEE', CAST(N'2006-04-30' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Etape] OFF
GO
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AA ', N'Antalgiques en association                                                      ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AAA', N'Antalgiques antipyrétiques en association                                       ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AAC', N'Antidépresseur d’action centrale                                                ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AAH', N'Antivertigineux antihistaminique H1                                             ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'ABA', N'Antibiotique antituberculeux                                                    ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'ABC', N'Antibiotique antiacnéique local                                                 ', 1)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'ABP', N'Antibiotique de la famille des béta-lactamines (pénicilline A)                  ', 1)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AFC', N'Antibiotique de la famille des cyclines                                         ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AFM', N'Antibiotique de la famille des macrolides                                       ', 1)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AH ', N'Antihistaminique H1 local                                                       ', 1)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AIM', N'Antidépresseur imipraminique (tricyclique)                                      ', 1)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AIN', N'Antidépresseur inhibiteur sélectif de la recapture de la sérotonine             ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'ALO', N'Antibiotique local (ORL)                                                        ', 2)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'ANS', N'Antidépresseur IMAO non sélectif                                                ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AO ', N'Antibiotique ophtalmique                                                        ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AP ', N'Antipsychotique normothymique                                                   ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'AUM', N'Antibiotique urinaire minute                                                    ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'CRT', N'"Corticoïde                                                                     ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'HYP', N'Hypnotique antihistaminique                                                     ', NULL)
INSERT [dbo].[Famille] ([fam_code], [fam_libelle], [fam_nbMediAmm]) VALUES (N'PSA', N'"Psychostimulant                                                                ', NULL)
GO
SET IDENTITY_INSERT [dbo].[Historique] ON 

INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (6, 1, 7, CAST(N'2020-12-11T14:52:56.787' AS DateTime), CAST(N'2008-03-17' AS Date), CAST(N'2008-03-17' AS Date), N'4', N'4')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (8, 1, 8, CAST(N'2020-12-11T17:05:45.967' AS DateTime), CAST(N'2005-04-30' AS Date), CAST(N'2005-04-30' AS Date), N'6', N'6')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (10, 1, 8, CAST(N'2020-12-11T17:18:04.550' AS DateTime), CAST(N'2005-04-30' AS Date), CAST(N'2006-04-30' AS Date), N'6', N'6')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (14, 1, 3, CAST(N'2020-12-18T04:35:46.043' AS DateTime), CAST(N'2004-05-15' AS Date), CAST(N'2004-05-12' AS Date), N'1', N'7')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (16, 1, 5, CAST(N'2020-12-18T04:36:15.200' AS DateTime), CAST(N'2012-01-18' AS Date), CAST(N'2012-01-18' AS Date), N'5', N'1')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (17, 1, 5, CAST(N'2020-12-18T04:36:28.137' AS DateTime), CAST(N'2012-01-18' AS Date), CAST(N'2012-05-01' AS Date), N'1', N'1')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (18, 1, 5, CAST(N'2020-12-18T04:36:36.783' AS DateTime), CAST(N'2012-05-01' AS Date), CAST(N'2012-01-05' AS Date), N'1', N'1')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (19, 1, 7, CAST(N'2020-12-18T04:37:09.930' AS DateTime), CAST(N'2008-03-17' AS Date), CAST(N'2008-03-15' AS Date), N'4', N'4')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (20, 1, 5, CAST(N'2020-12-18T05:22:53.417' AS DateTime), CAST(N'2012-01-05' AS Date), CAST(N'2012-01-05' AS Date), N'1', N'6')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (21, 1, 8, CAST(N'2020-12-18T05:23:31.310' AS DateTime), CAST(N'2006-04-30' AS Date), CAST(N'2006-04-30' AS Date), N'6', N'6')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (22, 1, 5, CAST(N'2020-12-18T05:23:39.257' AS DateTime), CAST(N'2012-01-05' AS Date), CAST(N'2012-01-05' AS Date), N'6', N'1')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (23, 1, 3, CAST(N'2020-12-18T07:13:33.733' AS DateTime), CAST(N'2004-05-12' AS Date), CAST(N'2004-05-13' AS Date), N'7', N'7')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (24, 1, 3, CAST(N'2020-12-18T07:19:22.310' AS DateTime), CAST(N'2004-05-13' AS Date), CAST(N'2005-05-13' AS Date), N'7', N'7')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (25, 1, 3, CAST(N'2020-12-18T07:20:27.347' AS DateTime), CAST(N'2005-05-13' AS Date), CAST(N'2005-05-17' AS Date), N'7', N'7')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (26, 1, 3, CAST(N'2020-12-18T07:21:00.650' AS DateTime), CAST(N'2005-05-17' AS Date), CAST(N'2005-05-17' AS Date), N'7', N'7')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (27, 1, 3, CAST(N'2020-12-18T07:23:30.930' AS DateTime), CAST(N'2005-05-17' AS Date), CAST(N'2005-05-17' AS Date), N'7', N'7')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (28, 1, 5, CAST(N'2020-12-18T07:25:43.113' AS DateTime), CAST(N'2012-01-05' AS Date), CAST(N'2012-01-05' AS Date), N'1', N'1')
INSERT [dbo].[Historique] ([htq_id], [htq_user], [htq_etp_num], [htq_date_maj], [htq_date_old], [htq_date_new], [htq_norme_old], [htq_norme_new]) VALUES (29, 1, 5, CAST(N'2020-12-18T07:27:29.577' AS DateTime), CAST(N'2012-01-05' AS Date), CAST(N'2012-01-05' AS Date), N'1', N'1')
SET IDENTITY_INSERT [dbo].[Historique] OFF
GO
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'3MYC7     ', N'TRIMYCINE                ', N'Triamcinolone (acétonide) + Néomycine + Nystatine                                                                                                                                                                                                              ', N'"Ce médicament est un corticoïde à  activité forte ou très forte associé à  un antibiotique et un antifongique                                                                                                                                                 ', N' utilisé en application locale dans certaines atteintes cutanées surinfectées."                                                                                                                                                                                ', NULL, 2, N'CRT')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'ADIMOL9   ', N'ADIMOL                   ', N'Amoxicilline + Acide clavulanique                                                                                                                                                                                                                              ', N'"Ce médicament                                                                                                                                                                                                                                                 ', N' plus puissant que les pénicillines simples                                                                                                                                                                                                                    ', NULL, 2, N'ABP')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'AMOPIL7   ', N'AMOPIL                   ', N'Amoxicilline                                                                                                                                                                                                                                                   ', N'"Ce médicament                                                                                                                                                                                                                                                 ', N' plus puissant que les pénicillines simples                                                                                                                                                                                                                    ', N'2', 8, N'ABP')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'AMOX45    ', N'AMOXAR                   ', N'Amoxicilline                                                                                                                                                                                                                                                   ', N'"Ce médicament                                                                                                                                                                                                                                                 ', N' plus puissant que les pénicillines simples                                                                                                                                                                                                                    ', NULL, 7, N'ABP')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'AMOXIG12  ', N'AMOXI Gé                 ', N'Amoxicilline                                                                                                                                                                                                                                                   ', N'"Ce médicament                                                                                                                                                                                                                                                 ', N' plus puissant que les pénicillines simples                                                                                                                                                                                                                    ', NULL, 3, N'ABP')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'APATOUX22 ', N'APATOUX Vitamine C       ', N'Tyrothricine + Tétracaïne + Acide ascorbique (Vitamine C)                                                                                                                                                                                                      ', N'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.                                                                                                                                                                             ', N'"Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants                                                                                                                                                                                   ', NULL, 6, N'ALO')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'BACTIG10  ', N'BACTIGEL                 ', N'Erythromycine                                                                                                                                                                                                                                                  ', N'Ce médicament est utilisé en application locale pour traiter l’acné et les infections cutanées bactériennes associées.                                                                                                                                         ', N'Ce médicament est contre-indiqué en cas d’allergie aux antibiotiques de la famille des macrolides ou des lincosanides.                                                                                                                                         ', NULL, 4, N'ABC')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'BACTIV13  ', N'BACTIVIL                 ', N'Erythromycine                                                                                                                                                                                                                                                  ', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.                                                                                                                                                                                ', N'Ce médicament est contre-indiqué en cas d’allergie aux macrolides (dont le chef de file est l’érythromycine).                                                                                                                                                  ', NULL, 7, N'AFM')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'BITALV    ', N'BIVALIC                  ', N'Dextropropoxyphène + Paracétamol                                                                                                                                                                                                                               ', N'Ce médicament est utilisé pour traiter les douleurs d’intensité modérée ou intense.                                                                                                                                                                            ', N'"Ce médicament est contre-indiqué en cas d’allergie aux médicaments de cette famille                                                                                                                                                                           ', NULL, 7, N'AAA')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'CARTION6  ', N'CARTION                  ', N'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol                                                                                                                                                                               ', N'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.                                                                                                                                                                      ', N'"Ce médicament est contre-indiqué en cas de troubles de la coagulation (tendances aux hémorragies)                                                                                                                                                             ', NULL, NULL, N'AAA')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'CLAZER6   ', N'CLAZER                   ', N'Clarithromycine                                                                                                                                                                                                                                                ', N'"Ce médicament est utilisé pour traiter des infections bactériennes spécifiques. Il est également utilisé dans le traitement de l’ulcère gastro-duodénal                                                                                                       ', N' en association avec d’autres médicaments."                                                                                                                                                                                                                    ', NULL, 5, N'AFM')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'DEPRIL9   ', N'DEPRAMIL                 ', N'Clomipramine                                                                                                                                                                                                                                                   ', N'"Ce médicament est utilisé pour traiter les épisodes dépressifs sévères                                                                                                                                                                                        ', N' certaines douleurs rebelles                                                                                                                                                                                                                                   ', N'1', 8, N'AIM')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'DIMIRTAM6 ', N'DIMIRTAM                 ', N'Mirtazapine                                                                                                                                                                                                                                                    ', N'Ce médicament est utilisé pour traiter les épisodes dépressifs sévères.                                                                                                                                                                                        ', N'La prise de ce produit est contre-indiquée en cas de d’allergie à  l’un des constituants.                                                                                                                                                                      ', NULL, NULL, N'AAC')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'DOLRIL7   ', N'DOLORIL                  ', N'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol                                                                                                                                                                               ', N'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.                                                                                                                                                                      ', N'Ce médicament est contre-indiqué en cas d’allergie au paracétamol ou aux salicylates.                                                                                                                                                                          ', NULL, NULL, N'AAA')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'DORNOM8   ', N'NORMADOR                 ', N'Doxylamine                                                                                                                                                                                                                                                     ', N'Ce médicament est utilisé pour traiter l’insomnie chez l’adulte.                                                                                                                                                                                               ', N'"Ce médicament est contre-indiqué en cas de glaucome                                                                                                                                                                                                           ', NULL, NULL, N'HYP')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'EQUILARX6 ', N'EQUILAR                  ', N'Méclozine                                                                                                                                                                                                                                                      ', N'Ce médicament est utilisé pour traiter les vertiges et pour prévenir le mal des transports.                                                                                                                                                                    ', N'"Ce médicament ne doit pas être utilisé en cas d’allergie au produit                                                                                                                                                                                           ', NULL, NULL, N'AAH')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'EVILR7    ', N'EVEILLOR                 ', N'Adrafinil                                                                                                                                                                                                                                                      ', N'Ce médicament est utilisé pour traiter les troubles de la vigilance et certains symptomes neurologiques chez le sujet agé.                                                                                                                                     ', N'Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants.                                                                                                                                                                                   ', NULL, 1, N'PSA')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'INSXT5    ', N'INSECTIL                 ', N'Diphénydramine                                                                                                                                                                                                                                                 ', N'Ce médicament est utilisé en application locale sur les piqûres d’insecte et l’urticaire.                                                                                                                                                                      ', N'Ce médicament est contre-indiqué en cas d’allergie aux antihistaminiques.                                                                                                                                                                                      ', N'3', 8, N'AH ')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'JOVAI8    ', N'JOVENIL                  ', N'Josamycine                                                                                                                                                                                                                                                     ', N'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.                                                                                                                                                                                ', N'Ce médicament est contre-indiqué en cas d’allergie aux macrolides (dont le chef de file est l’érythromycine).                                                                                                                                                  ', NULL, 2, N'AFM')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'LIDOXY23  ', N'LIDOXYTRACINE            ', N'Oxytétracycline +Lidocaïne                                                                                                                                                                                                                                     ', N'Ce médicament est utilisé en injection intramusculaire pour traiter certaines infections spécifiques.                                                                                                                                                          ', N'Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants. Il ne doit pas être associé aux rétinoïdes.                                                                                                                                       ', NULL, 7, N'AFC')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'LITHOR12  ', N'LITHORINE                ', N'Lithium                                                                                                                                                                                                                                                        ', N'Ce médicament est indiqué dans la prévention des psychoses maniaco-dépressives ou pour traiter les états maniaques.                                                                                                                                            ', N'"Ce médicament ne doit pas être utilisé si vous êtes allergique au lithium. Avant de prendre ce traitement                                                                                                                                                     ', NULL, 3, N'AP ')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'PARMOL16  ', N'PARMOCODEINE             ', N'Codéine + Paracétamol                                                                                                                                                                                                                                          ', N'Ce médicament est utilisé pour le traitement des douleurs lorsque des antalgiques simples ne sont pas assez efficaces.                                                                                                                                         ', N'"Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants                                                                                                                                                                                   ', NULL, 1, N'AA ')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'PHYSOI8   ', N'PHYSICOR                 ', N'Sulbutiamine                                                                                                                                                                                                                                                   ', N'"Ce médicament est utilisé pour traiter les baisses d’activité physique ou psychique                                                                                                                                                                           ', N' souvent dans un contexte de dépression."                                                                                                                                                                                                                      ', NULL, 1, N'PSA')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'PIRIZ8    ', N'PIRIZAN                  ', N'Pyrazinamide                                                                                                                                                                                                                                                   ', N'"Ce médicament est utilisé                                                                                                                                                                                                                                     ', N' en association à  d’autres antibiotiques                                                                                                                                                                                                                      ', NULL, NULL, N'ABA')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'POMDI20   ', N'POMADINE                 ', N'Bacitracine                                                                                                                                                                                                                                                    ', N'Ce médicament est utilisé pour traiter les infections oculaires de la surface de l’oeil.                                                                                                                                                                       ', N'Ce médicament est contre-indiqué en cas d’allergie aux antibiotiques appliqués localement.                                                                                                                                                                     ', NULL, NULL, N'AO ')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'TROXT21   ', N'TROXADET                 ', N'Paroxétine                                                                                                                                                                                                                                                     ', N'Ce médicament est utilisé pour traiter la dépression et les troubles obsessionnels compulsifs. Il peut également être utilisé en prévention des crises de panique avec ou sans agoraphobie.                                                                    ', N'Ce médicament est contre-indiqué en cas d’allergie au produit.                                                                                                                                                                                                 ', NULL, NULL, N'AIN')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'TXISOL22  ', N'TOUXISOL Vitamine C      ', N'Tyrothricine + Acide ascorbique (Vitamine C)                                                                                                                                                                                                                   ', N'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.                                                                                                                                                                             ', N'Ce médicament est contre-indiqué en cas d’allergie à  l’un des constituants et chez l’enfant de moins de 6 ans.                                                                                                                                                ', NULL, NULL, N'ALO')
INSERT [dbo].[Medicament] ([med_depotLegal], [med_nomCommercial], [med_composition], [med_effets], [med_contreIndications], [med_amm], [med_derniereEtape], [med_codeFamille]) VALUES (N'URIEG6    ', N'URIREGUL                 ', N'Fosfomycine trométamol                                                                                                                                                                                                                                         ', N'Ce médicament est utilisé pour traiter les infections urinaires simples chez la femme de moins de 65 ans.                                                                                                                                                      ', N'La prise de ce médicament est contre-indiquée en cas d’allergie à  l’un des constituants et d’insuffisance rénale.                                                                                                                                             ', NULL, NULL, N'AUM')
GO
SET IDENTITY_INSERT [dbo].[Utilisateurs] ON 

INSERT [dbo].[Utilisateurs] ([usr_id], [usr_username], [usr_password]) VALUES (1, N'Admin', N'O2Esdae1BIpDX7bsgeUv+S1teVqLWpwXBw9qY8l6U7I=')
SET IDENTITY_INSERT [dbo].[Utilisateurs] OFF
GO
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'3MYC7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'ADIMOL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'AMOPIL7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'AMOX45    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-05' AS Date), 1, 1, N'AMOXIG12  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'APATOUX22')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-04' AS Date), 1, 1, N'BACTIG10  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'BACTIV13  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'BITALV')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-15' AS Date), 1, 1, N'CLAZER6')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'DEPRIL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'EVILR7    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'INSXT5    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'JOVAI8    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-04' AS Date), 1, 1, N'LIDOXY23  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'LITHOR12  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'PARMOL16  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-01' AS Date), 1, 1, N'PHYSOI8   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 2, N'3MYC7     ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-12' AS Date), 2, 1, N'ADIMOL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-03' AS Date), 2, 1, N'AMOPIL7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 1, N'AMOX45    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 2, 1, N'AMOXIG12  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-12-17' AS Date), 2, 1, N'APATOUX22 ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-05' AS Date), 2, 1, N'BACTIG10  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 1, N'BACTIV13  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 1, N'BITALV')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-17' AS Date), 2, 1, N'CLAZER6')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 1, N'DEPRIL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 1, N'INSXT5    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 1, N'JOVAI8    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 2, 1, N'LIDOXY23  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 1, N'LITHOR12  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-02' AS Date), 2, 2, N'PARMOL16  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-26' AS Date), 3, 2, N'ADIMOL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-01-04' AS Date), 3, 1, N'AMOPIL7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-03' AS Date), 3, 1, N'AMOX45    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-06-06' AS Date), 3, 1, N'AMOXIG12  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-15' AS Date), 3, 1, N'APATOUX22')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-03' AS Date), 3, 1, N'BACTIG10  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-03' AS Date), 3, 1, N'BACTIV13  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-05' AS Date), 3, 1, N'BITALV')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-02-28' AS Date), 3, 1, N'CLAZER6')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-03' AS Date), 3, 1, N'DEPRIL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-03' AS Date), 3, 1, N'INSXT5    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-03' AS Date), 3, 2, N'JOVAI8    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-06-06' AS Date), 3, 1, N'LIDOXY23  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-03' AS Date), 3, 1, N'LITHOR12  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 4, 1, N'AMOPIL7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-04' AS Date), 4, 1, N'AMOX45 ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-08-08' AS Date), 4, 1, N'APATOUX22')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-04' AS Date), 4, 1, N'BACTIG10  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-04' AS Date), 4, 1, N'BACTIV13  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-03' AS Date), 4, 1, N'BITALV')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-01' AS Date), 4, 1, N'CLAZER6')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-04' AS Date), 4, 1, N'DEPRIL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-04' AS Date), 4, 1, N'INSXT5    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-07-07' AS Date), 4, 1, N'LIDOXY23  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-04' AS Date), 4, 2, N'LITHOR12  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-06-06' AS Date), 5, 1, N'AMOPIL7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 5, 1, N'AMOX45    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-11-29' AS Date), 5, 1, N'APATOUX22 ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 5, 2, N'BACTIG10  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 5, 1, N'BACTIV13  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-04' AS Date), 5, 1, N'BITALV')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-03-15' AS Date), 5, 2, N'CLAZER6')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-04-24' AS Date), 5, 1, N'DEPRIL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 5, 1, N'INSXT5    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-08-08' AS Date), 5, 1, N'LIDOXY23  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-07-07' AS Date), 6, 1, N'AMOPIL7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-06-06' AS Date), 6, 1, N'AMOX45    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-06-06' AS Date), 6, 1, N'BACTIV13  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 6, 1, N'BITALV')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-05-05' AS Date), 6, 1, N'DEPRIL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-06-06' AS Date), 6, 1, N'INSXT5    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-09-09' AS Date), 6, 1, N'LIDOXY23  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-08-08' AS Date), 7, 1, N'AMOPIL7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-07-07' AS Date), 7, 1, N'AMOX45    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-06-06' AS Date), 7, 1, N'BITALV')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-06-06' AS Date), 7, 1, N'DEPRIL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-07-07' AS Date), 7, 1, N'INSXT5    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-10-10' AS Date), 7, 1, N'LIDOXY23  ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-09-09' AS Date), 8, 1, N'AMOPIL7   ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-08-08' AS Date), 8, 2, N'AMOX45    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-07-07' AS Date), 8, 2, N'BITALV')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-07-07' AS Date), 8, 1, N'DEPRIL9')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-08-08' AS Date), 8, 1, N'INSXT5    ')
INSERT [dbo].[Workflow] ([wkf_date_decision], [wkf_etp_num], [wkf_dcs_id], [wkf_med_id]) VALUES (CAST(N'2020-11-11' AS Date), 8, 2, N'LIDOXY23  ')
GO
ALTER TABLE [dbo].[Historique]  WITH CHECK ADD  CONSTRAINT [FK_Historique_Etape] FOREIGN KEY([htq_etp_num])
REFERENCES [dbo].[Etape] ([etp_num])
GO
ALTER TABLE [dbo].[Historique] CHECK CONSTRAINT [FK_Historique_Etape]
GO
ALTER TABLE [dbo].[Historique]  WITH CHECK ADD  CONSTRAINT [FK_Historique_Utilisateurs] FOREIGN KEY([htq_user])
REFERENCES [dbo].[Utilisateurs] ([usr_id])
GO
ALTER TABLE [dbo].[Historique] CHECK CONSTRAINT [FK_Historique_Utilisateurs]
GO
ALTER TABLE [dbo].[Medicament]  WITH CHECK ADD  CONSTRAINT [FK_Medicament_Famille] FOREIGN KEY([med_codeFamille])
REFERENCES [dbo].[Famille] ([fam_code])
GO
ALTER TABLE [dbo].[Medicament] CHECK CONSTRAINT [FK_Medicament_Famille]
GO
ALTER TABLE [dbo].[Workflow]  WITH CHECK ADD  CONSTRAINT [FK_Workflow_Decision] FOREIGN KEY([wkf_dcs_id])
REFERENCES [dbo].[Decision] ([dcs_id])
GO
ALTER TABLE [dbo].[Workflow] CHECK CONSTRAINT [FK_Workflow_Decision]
GO
ALTER TABLE [dbo].[Workflow]  WITH CHECK ADD  CONSTRAINT [FK_Workflow_Etape] FOREIGN KEY([wkf_etp_num])
REFERENCES [dbo].[Etape] ([etp_num])
GO
ALTER TABLE [dbo].[Workflow] CHECK CONSTRAINT [FK_Workflow_Etape]
GO
ALTER TABLE [dbo].[Workflow]  WITH CHECK ADD  CONSTRAINT [FK_Workflow_Medicament] FOREIGN KEY([wkf_med_id])
REFERENCES [dbo].[Medicament] ([med_depotLegal])
GO
ALTER TABLE [dbo].[Workflow] CHECK CONSTRAINT [FK_Workflow_Medicament]
GO
/****** Object:  StoredProcedure [dbo].[prc_ajouterWorkflow]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_ajouterWorkflow](@laDateDecision date, @leWkfEtpNum int, @leWkfDcsdId int, @leWkfMedId nvarchar(10))
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Workflow VALUES (@laDateDecision, @leWkfEtpNum, @leWkfDcsdId, @leWkfMedId)
END
GO
/****** Object:  StoredProcedure [dbo].[prc_ajoutMedicament]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_ajoutMedicament](
	-- Add the parameters for the stored procedure here
	@leDepotLegal as Nvarchar(10), 
	@leNomCommercial as Nvarchar(25),
	@laComposition as Nvarchar(255),
	@lesEffets as Nvarchar(255),
	@lesContreIndic as Nvarchar(255),
	@leCodeFamille as Nvarchar(3))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	if not exists (select med_depotLegal from Medicament where med_depotLegal = @leDepotLegal)
	begin
		insert into Medicament(med_depotLegal, med_nomCommercial, med_composition, med_effets, med_contreIndications, med_codeFamille)
		values(@leDepotLegal, @leNomCommercial, @laComposition, @lesEffets, @lesContreIndic, @leCodeFamille)
	end
    -- Insert statements for procedure here
	
END
GO
/****** Object:  StoredProcedure [dbo].[prc_decision]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_decision]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM dbo.Decision
END
GO
/****** Object:  StoredProcedure [dbo].[prc_derniereEtapeNormee]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_derniereEtapeNormee](@depotlegal nvarchar(10))
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MAX(wkf_date_decision) AS max_derniereEtape, wkf_dcs_id, wkf_med_id, wkf_etp_num 
	from Workflow 
	where wkf_med_id = @depotlegal
	group by wkf_dcs_id, wkf_med_id, wkf_etp_num
END
GO
/****** Object:  StoredProcedure [dbo].[prc_etape]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_etape]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM dbo.Etape
END
GO
/****** Object:  StoredProcedure [dbo].[prc_etape_normee]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_etape_normee]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Etape where etp_norme is not null and etp_date_norme is not null
END
GO
/****** Object:  StoredProcedure [dbo].[prc_famille]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_famille]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM dbo.Famille
END
GO
/****** Object:  StoredProcedure [dbo].[prc_historique]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_historique]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM dbo.Historique
END
GO
/****** Object:  StoredProcedure [dbo].[prc_listeTousMedicaments]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_listeTousMedicaments]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.Medicament;
END
GO
/****** Object:  StoredProcedure [dbo].[prc_listeWorkflow]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_listeWorkflow](@numMedicament nvarchar(10))
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from dbo.Workflow where dbo.Workflow.wkf_med_id = @numMedicament
	ORDER BY dbo.Workflow.wkf_etp_num
END
GO
/****** Object:  StoredProcedure [dbo].[prc_MAJ_etape_normee]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_MAJ_etape_normee](@etp_date_norme date, @etp_norme nvarchar(20), @etp_num int, @etp_user_id int)
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Etape
	SET etp_date_norme = @etp_date_norme, etp_norme = @etp_norme, etp_user_id = @etp_user_id
	WHERE etp_num = @etp_num
END
GO
/****** Object:  StoredProcedure [dbo].[prc_utilisateur]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_utilisateur]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM dbo.Utilisateurs
END
GO
/****** Object:  Trigger [dbo].[trg_after_update_etape_normee]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_after_update_etape_normee]
   ON [dbo].[Etape]
   AFTER UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @etp_num int
	DECLARE @etp_norme_old nvarchar
	DECLARE @etp_date_norme_old date

	DECLARE @norme_new nvarchar
	DECLARE @date_norme_new date

	DECLARE @htq_date_maj datetime
	DECLARE @htq_user int

	SELECT @etp_num = etp_num, @etp_date_norme_old = etp_date_norme, @etp_norme_old = etp_norme from deleted

	SELECT @norme_new = etp_norme, @date_norme_new = etp_date_norme, @htq_user = etp_user_id from inserted


	SELECT @htq_date_maj = GETDATE()

	INSERT INTO Historique (htq_user, htq_etp_num, htq_date_maj, htq_date_old, htq_date_new, htq_norme_old, htq_norme_new) VALUES(@htq_user, @etp_num, @htq_date_maj, @etp_date_norme_old, @date_norme_new, @etp_norme_old, @norme_new)

    -- Insert statements for trigger here

END
GO
ALTER TABLE [dbo].[Etape] ENABLE TRIGGER [trg_after_update_etape_normee]
GO
/****** Object:  Trigger [dbo].[trg_after_insert_workflow]    Script Date: 18/12/2020 07:35:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[trg_after_insert_workflow]
   ON [dbo].[Workflow]
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @wkf_etp_num int
	DECLARE @wkf_dcs_id int
	DECLARE @wkf_date_decision date
	DECLARE @wkf_med_id nvarchar(10)

	DECLARE @fam_code nvarchar(3)
	DECLARE @fam_nbmediamm int


	SELECT @wkf_etp_num = wkf_etp_num, @wkf_date_decision = wkf_date_decision, @wkf_dcs_id = wkf_dcs_id, @wkf_med_id = wkf_med_id from inserted

	SELECT @fam_code = med_codeFamille from Medicament WHERE med_depotLegal = @wkf_med_id

	SELECT @fam_nbmediamm = fam_nbMediAmm from Famille WHERE fam_code = @fam_code

	IF @wkf_dcs_id = 1
		UPDATE Medicament
		SET med_derniereEtape = @wkf_etp_num
		WHERE med_depotLegal = @wkf_med_id
	
	

	IF @fam_nbmediamm IS NULL AND @wkf_etp_num = 8 AND @wkf_dcs_id = 1
	BEGIN
		UPDATE Famille
		SET fam_nbMediAmm = 1
		WHERE fam_code = @fam_code
	END
	
	ELSE
	BEGIN
		IF @fam_nbmediamm IS NOT NULL AND @wkf_etp_num = 8 AND @wkf_dcs_id = 1
		BEGIN
			UPDATE Famille
			SET fam_nbMediAmm = fam_nbMediAmm + 1
			WHERE fam_code = @fam_code
		END
	END

    -- Insert statements for trigger here

END
GO
ALTER TABLE [dbo].[Workflow] ENABLE TRIGGER [trg_after_insert_workflow]
GO
