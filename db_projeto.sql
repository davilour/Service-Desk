-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 30-Nov-2022 às 20:22
-- Versão do servidor: 10.1.32-MariaDB
-- PHP Version: 7.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_projeto`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_atendente`
--

CREATE TABLE `tb_atendente` (
  `id_atendente` smallint(6) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `senha` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_atendente`
--

INSERT INTO `tb_atendente` (`id_atendente`, `nome`, `cpf`, `senha`) VALUES
(1, 'Eu', '123,123,123-12', '81dc9bdb52d04dc20036dbd8313ed055');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_atendimento`
--

CREATE TABLE `tb_atendimento` (
  `id_atendimento` smallint(6) NOT NULL,
  `id_atendente` smallint(6) NOT NULL,
  `id_cliente` smallint(6) NOT NULL,
  `id_tecnico` smallint(6) DEFAULT NULL,
  `id_categoria` smallint(6) NOT NULL,
  `id_subcategoria` smallint(6) NOT NULL,
  `id_operacao` smallint(6) NOT NULL,
  `id_situacao` smallint(6) NOT NULL,
  `id_urgencia` smallint(6) NOT NULL,
  `id_tipo_atendimento` smallint(6) NOT NULL,
  `descricao` varchar(255) NOT NULL,
  `presencial` varchar(255) DEFAULT NULL,
  `hist` varchar(255) DEFAULT NULL,
  `hora` varchar(20) DEFAULT NULL,
  `dia` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_atendimento`
--

INSERT INTO `tb_atendimento` (`id_atendimento`, `id_atendente`, `id_cliente`, `id_tecnico`, `id_categoria`, `id_subcategoria`, `id_operacao`, `id_situacao`, `id_urgencia`, `id_tipo_atendimento`, `descricao`, `presencial`, `hist`, `hora`, `dia`) VALUES
(27, 1, 1, 2, 1, 1, 1, 1, 1, 1, '', 'Não', '', '30/11/2022 11:11:00', '  /  /');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_categoria`
--

CREATE TABLE `tb_categoria` (
  `id_categoria` smallint(6) NOT NULL,
  `categoria` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_categoria`
--

INSERT INTO `tb_categoria` (`id_categoria`, `categoria`) VALUES
(1, ''),
(2, 'Hardware'),
(3, 'Software');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cliente`
--

CREATE TABLE `tb_cliente` (
  `id_cliente` smallint(6) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `endereco` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cliente`
--

INSERT INTO `tb_cliente` (`id_cliente`, `nome`, `cpf`, `telefone`, `endereco`) VALUES
(1, 'Adams', '076,565,423-34', '(41) 98946-4864', 'Rua 1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_operacao`
--

CREATE TABLE `tb_operacao` (
  `id_operacao` smallint(6) NOT NULL,
  `operacao` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_operacao`
--

INSERT INTO `tb_operacao` (`id_operacao`, `operacao`) VALUES
(1, NULL),
(2, 'Instalado '),
(3, 'Desinstalado  '),
(4, 'Limpado'),
(5, 'Substituída ');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_situacao`
--

CREATE TABLE `tb_situacao` (
  `id_situacao` smallint(6) NOT NULL,
  `condicao` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_situacao`
--

INSERT INTO `tb_situacao` (`id_situacao`, `condicao`) VALUES
(1, ''),
(2, 'Resolvido'),
(3, 'Não resolvido');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_sub_categoria`
--

CREATE TABLE `tb_sub_categoria` (
  `id_subcategoria` smallint(6) NOT NULL,
  `subcategoria` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_sub_categoria`
--

INSERT INTO `tb_sub_categoria` (`id_subcategoria`, `subcategoria`) VALUES
(1, NULL),
(2, 'Word'),
(3, 'Excel'),
(4, 'Powerpoint'),
(5, 'DVD');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tecnico`
--

CREATE TABLE `tb_tecnico` (
  `id_tecnico` smallint(6) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `telefone` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_tecnico`
--

INSERT INTO `tb_tecnico` (`id_tecnico`, `nome`, `cpf`, `telefone`) VALUES
(1, '', '', ''),
(2, 'Davi', '789,764,573-48', '(41) 98948-9489');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_tipo_atendimento`
--

CREATE TABLE `tb_tipo_atendimento` (
  `id_tipo_atendimento` smallint(6) NOT NULL,
  `tipo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_tipo_atendimento`
--

INSERT INTO `tb_tipo_atendimento` (`id_tipo_atendimento`, `tipo`) VALUES
(1, ''),
(2, 'Problema '),
(3, 'Solicitação'),
(4, 'Incidente');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_urgencia`
--

CREATE TABLE `tb_urgencia` (
  `id_urgencia` smallint(6) NOT NULL,
  `urgencia` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_urgencia`
--

INSERT INTO `tb_urgencia` (`id_urgencia`, `urgencia`) VALUES
(1, ''),
(2, 'Pouco urgente'),
(3, 'Urgente'),
(4, 'Muito Urgente');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_atendente`
--
ALTER TABLE `tb_atendente`
  ADD PRIMARY KEY (`id_atendente`),
  ADD UNIQUE KEY `cpf` (`cpf`);

--
-- Indexes for table `tb_atendimento`
--
ALTER TABLE `tb_atendimento`
  ADD PRIMARY KEY (`id_atendimento`),
  ADD KEY `fk_tb_atendente` (`id_atendente`),
  ADD KEY `fk_tb_cliente` (`id_cliente`),
  ADD KEY `fk_tb_tecnico` (`id_tecnico`),
  ADD KEY `fk_tb_categoria` (`id_categoria`),
  ADD KEY `fk_tb_sub_categoria` (`id_subcategoria`),
  ADD KEY `fk_tb_operacao` (`id_operacao`),
  ADD KEY `fk_tb_situacao` (`id_situacao`),
  ADD KEY `fk_tb_urgencia` (`id_urgencia`),
  ADD KEY `fk_tb_tipo_atendimento` (`id_tipo_atendimento`);

--
-- Indexes for table `tb_categoria`
--
ALTER TABLE `tb_categoria`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Indexes for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD UNIQUE KEY `cpf` (`cpf`);

--
-- Indexes for table `tb_operacao`
--
ALTER TABLE `tb_operacao`
  ADD PRIMARY KEY (`id_operacao`);

--
-- Indexes for table `tb_situacao`
--
ALTER TABLE `tb_situacao`
  ADD PRIMARY KEY (`id_situacao`);

--
-- Indexes for table `tb_sub_categoria`
--
ALTER TABLE `tb_sub_categoria`
  ADD PRIMARY KEY (`id_subcategoria`);

--
-- Indexes for table `tb_tecnico`
--
ALTER TABLE `tb_tecnico`
  ADD PRIMARY KEY (`id_tecnico`),
  ADD UNIQUE KEY `cpf` (`cpf`);

--
-- Indexes for table `tb_tipo_atendimento`
--
ALTER TABLE `tb_tipo_atendimento`
  ADD PRIMARY KEY (`id_tipo_atendimento`);

--
-- Indexes for table `tb_urgencia`
--
ALTER TABLE `tb_urgencia`
  ADD PRIMARY KEY (`id_urgencia`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_atendente`
--
ALTER TABLE `tb_atendente`
  MODIFY `id_atendente` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tb_atendimento`
--
ALTER TABLE `tb_atendimento`
  MODIFY `id_atendimento` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tb_categoria`
--
ALTER TABLE `tb_categoria`
  MODIFY `id_categoria` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tb_cliente`
--
ALTER TABLE `tb_cliente`
  MODIFY `id_cliente` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tb_operacao`
--
ALTER TABLE `tb_operacao`
  MODIFY `id_operacao` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_situacao`
--
ALTER TABLE `tb_situacao`
  MODIFY `id_situacao` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tb_sub_categoria`
--
ALTER TABLE `tb_sub_categoria`
  MODIFY `id_subcategoria` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tb_tecnico`
--
ALTER TABLE `tb_tecnico`
  MODIFY `id_tecnico` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tb_tipo_atendimento`
--
ALTER TABLE `tb_tipo_atendimento`
  MODIFY `id_tipo_atendimento` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tb_urgencia`
--
ALTER TABLE `tb_urgencia`
  MODIFY `id_urgencia` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tb_atendimento`
--
ALTER TABLE `tb_atendimento`
  ADD CONSTRAINT `fk_tb_atendente` FOREIGN KEY (`id_atendente`) REFERENCES `tb_atendente` (`id_atendente`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tb_categoria` FOREIGN KEY (`id_categoria`) REFERENCES `tb_categoria` (`id_categoria`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tb_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `tb_cliente` (`id_cliente`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tb_operacao` FOREIGN KEY (`id_operacao`) REFERENCES `tb_operacao` (`id_operacao`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tb_situacao` FOREIGN KEY (`id_situacao`) REFERENCES `tb_situacao` (`id_situacao`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tb_sub_categoria` FOREIGN KEY (`id_subcategoria`) REFERENCES `tb_sub_categoria` (`id_subcategoria`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tb_tecnico` FOREIGN KEY (`id_tecnico`) REFERENCES `tb_tecnico` (`id_tecnico`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tb_tipo_atendimento` FOREIGN KEY (`id_tipo_atendimento`) REFERENCES `tb_tipo_atendimento` (`id_tipo_atendimento`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_tb_urgencia` FOREIGN KEY (`id_urgencia`) REFERENCES `tb_urgencia` (`id_urgencia`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
