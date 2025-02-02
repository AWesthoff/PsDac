# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

- Added UpdateExisting switch to install command.
- Added `Export-DacModel` command.
- Added database option to import model or package from.
- Added `New-SchemaComparison` command.

### Changed

- Updated powershell version.

## [1.2.0] - 2022-07-30

### Added

- Pipeline input for Disconnect-Service.

## [1.1.0] - 2022-07-30

### Added

- Default parameter set ConnectionString for Connect-Service.

## [1.0.0] - 2022-05-12

### Added

- Added `Connect-DacService` command.
- Added `Disconnect-DacService` command.
- Added `Install-DacPackage` command.
- Added output to all commands.
- Added documentation.

### Changed

- Changed type of the Name property in `Get-DacDataType` output from SqlDataType to string.

### Fixed

- `Get-DacDataType` works for user defined types and CLI types.

## [0.2.0] - 2021-10-15

### Added

- Added variable handling to `New-DacCreateScript` command.
- Added `Get-DacTableValuedFunction` command.

<!-- markdownlint-configure-file {"MD024": { "siblings_only": true } } -->
