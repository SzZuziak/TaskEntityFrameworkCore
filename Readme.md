# Goals:
Tabele: 
Team (Id, Name)
TeamMember (Id, FirstName, LastName, Title (Enum))
Enum (Developer, ScrumMuster, ProjectOwner, ...)

1 do wiele (Team -> TeamMember).

Utworzyć projekt gdzie:
- Będą migracje
- Będzie udowodniony LazyLoading
- Rozwiązany select N+1
- Więzy intergralności (SetNull gdy usuwany TeamMember).


# Migration
add-migration TeamDB
update-database –verbose