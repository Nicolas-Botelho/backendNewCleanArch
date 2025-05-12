-- Desabilitar constraints de chave estrangeira
ALTER TABLE Propriedade NOCHECK CONSTRAINT ALL;
ALTER TABLE Agricultor NOCHECK CONSTRAINT ALL;

-- Deletar dados das tabelas
DELETE FROM Propriedade;
DELETE FROM Agricultor;

-- Habilitar constraints de chave estrangeira
ALTER TABLE Propriedade WITH CHECK CHECK CONSTRAINT ALL;
ALTER TABLE Agricultor WITH CHECK CHECK CONSTRAINT ALL;