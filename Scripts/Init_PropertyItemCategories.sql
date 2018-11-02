
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (1, 'Phone','电话', NULL);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (2, 'Email','邮箱', NULL);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (3, 'Address','地址', NULL);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (4, 'Certificate','证件', NULL);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (5, 'Person','重要人物', NULL);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (6, 'DateTime','重要日期', NULL);

INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (10, 'MainPhone','主要', 1);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (11, 'Mobile','手机', 1);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (12, 'HomePhone','家庭电话', 1);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (13, 'OfficePhone','办公电话', 1);

INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (20, 'MainEmail','主要', 2);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (21, 'PersonalEmail','个人邮箱', 2);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (22, 'RegisterEmail','注册邮箱', 2);

INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (30, 'MainAddress','主要', 3);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (31, 'HomeAddress','家庭地址', 3);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (32, 'OfficeAddress','办公地址', 3);

INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (41, 'IDCard','身份证', 4);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (42, 'Passport','护照', 4);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (43, 'OfficialCard','军官证', 4);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (44, 'BusinessLicence','营业执照', 4);

INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (51, 'LegalPerson','法人', 5);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (52, 'HeadPerson','负责人', 5);

INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (61, 'RegisterDate','注册日期', 6);
INSERT INTO PropertyItemCategories(Id,Code,Name,ParentId) VALUES (62, 'HeadPerson','负责人', 6);
