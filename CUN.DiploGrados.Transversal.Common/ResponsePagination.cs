namespace CUN.DiploGrados.Transversal.Common
{
    public class ResponsePagination<T> : ResponseGeneric<T>
    {
        // Se puede llegar a manjear mediante procedimiento almacenado
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }

        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;
    }
}
