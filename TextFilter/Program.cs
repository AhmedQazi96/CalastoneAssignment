using SimpleInjector;
using TextFilter;

var container = ConfigureContainer();

string currentDirectory = Directory.GetCurrentDirectory();
string relativeFilePath = $"Texts\\TextInput.txt";
string absoluteFilePath = Path.Combine(currentDirectory, relativeFilePath);

var reader = container.GetInstance<ITextReader>();

string fileContents = reader.ReadText(absoluteFilePath);

var filterProcessor = container.GetInstance<ITextFilterProcessor>();

string filteredText = filterProcessor.ApplyFilters(fileContents);

Console.WriteLine(filteredText);

container.Dispose();

static Container ConfigureContainer()
{
    var container = new Container();

    container.Register<ITextReader, TextFilter.TextReader>();
    container.Register<ITextFilterProcessor, TextFilterProcessor>();
    container.Collection.Register<ITextFilter>(typeof(LengthFilter), typeof(LetterTFilter), typeof(VowelInMiddleFilter));

    container.Verify();

    return container;
}