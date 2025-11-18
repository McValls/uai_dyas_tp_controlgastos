@echo off
setlocal enabledelayedexpansion
REM =================================================================
REM SQL Server Database Initialization Script
REM =================================================================
REM This script initializes the Control_Gastos database by:
REM 1. Creating the database and tables
REM 2. Inserting loan configuration data
REM 3. Loading mock data
REM 4. Creating all stored procedures
REM =================================================================

REM Configuration - Modify these variables as needed
SET SERVER=localhost
SET USERNAME=
SET PASSWORD=

REM Database name
SET DATABASE=Control_Gastos

echo ========================================
echo Starting Database Initialization
echo ========================================
echo.

echo [1/5] Creating database and tables...
sqlcmd -S %SERVER% -i "01_create_db.sql"
if %ERRORLEVEL% NEQ 0 (
    echo ERROR: Failed to create database and tables
    pause
    exit /b 1
)
echo Database and tables created successfully.
echo.

echo [2/5] Inserting tables...
sqlcmd -S %SERVER% -d %DATABASE% -i "02_init_tables.sql"
if %ERRORLEVEL% NEQ 0 (
    echo ERROR: Failed to create tables
    pause
    exit /b 1
)
echo Tables created successfully.
echo.

echo [3/5] Inserting tables...
sqlcmd -S %SERVER% -d %DATABASE% -i "03_insert_configs_prestamos.sql"
if %ERRORLEVEL% NEQ 0 (
    echo ERROR: Failed to insert loan configuration
    pause
    exit /b 1
)
echo Loan configuration inserted successfully.
echo.

echo [4/5] Loading mock data...
sqlcmd -S %SERVER% -d %DATABASE% -i "mock_data.sql"
if %ERRORLEVEL% NEQ 0 (
    echo ERROR: Failed to load mock data
    pause
    exit /b 1
)
echo Mock data loaded successfully.
echo.

REM Step 4: Create Stored Procedures
echo [5/5] Creating stored procedures...
SET PROC_COUNT=0

for %%f in ("Store Procedures\*.sql") do (
    echo   Creating: %%~nxf
    sqlcmd -S %SERVER% -d %DATABASE% -i "%%f"
    if !ERRORLEVEL! NEQ 0 (
        echo ERROR: Failed to create stored procedure: %%~nxf
        pause
        exit /b 1
    )
    SET /A PROC_COUNT+=1
)

echo All %PROC_COUNT% stored procedures created successfully.
echo.

echo ========================================
echo Database Initialization Complete!
echo ========================================
echo.
echo Summary:
echo - Database and tables created
echo - Loan configurations inserted
echo - Mock data loaded (4 test users)
echo - %PROC_COUNT% stored procedures created
echo.
echo Default test user credentials:
echo   Username: User1, User2, User3, or User4
echo   Password: Usuario1234
echo.

pause

