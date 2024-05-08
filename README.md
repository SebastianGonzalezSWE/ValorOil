Name: Sebastian Gonzalez

Hello, This is my Oil Well Managaement project called Valor! 
This project allows for easy management of an Oil Production field, allowing for easier management of Operators, Wells, and Reports. 


//dotnet ef migrations add InitialCreate 
//dotnet ef database update

dotnet aspnet-codegenerator razorpage -m Professor -dc ProfessorDBContext -udl -outDir Pages\Professors --referenceScriptLibraries -sqlite

dotnet aspnet-codegenerator razorpage -m Well -dc ValorContext -udl -outDir Pages\Wells --referenceScriptLibraries -sqlite


 <form>
    <input type="search" placeholder="Search" aria-label="Search">
    <button type="submit">Search</button>
  </form>

  <p>
    <form>
        <input type="Search" placeholder="Search well names" aria-label="Search well names">
        <button type="submit">Search</button>
    </form>
</p>