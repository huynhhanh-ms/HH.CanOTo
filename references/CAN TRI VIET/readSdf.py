from sqlalchemy import create_engine, MetaData, Table

# Replace 'your_file.sdf' with the path to your SDF file
sdf_file_path = 'CanOtoTriViet.sdf'

# SQLAlchemy engine for SQL Server Compact Edition
engine = create_engine(f"mssql+pyodbc:///?odbc_connect=DRIVER=Microsoft SQL Server Compact Edition 3.5;"
                       f"DATABASE={sdf_file_path};Persist Security Info=False;")

# Create a SQLAlchemy metadata object
metadata = MetaData()

# Load all tables from the database
metadata.reflect(bind=engine)

# Assuming you have a table named 'your_table' in the SDF file
your_table = Table('your_table', metadata, autoload=True, autoload_with=engine)

# Query the data from the table
with engine.connect() as connection:
    result = connection.execute(your_table.select()).fetchall()
    for row in result:
        print(row)

