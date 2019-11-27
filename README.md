# School Management ERP

This is school Management ERP which can be used by any private and government institution

## Installation

Clone the project
Open .sln file 
Run Build
Change Connectionstring from app.config
Datasource to your datasource


## Migrations
bash
``` for first time
```Enable-Migrations

```
## After enabling migrations run migration by following command and by using following syntax

Add-Migraion <filename>  ----- filename = timestamp ==>month.day.year.hour.minutes i.e 112720191018
## finally Update your database by
Update-Database

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.
