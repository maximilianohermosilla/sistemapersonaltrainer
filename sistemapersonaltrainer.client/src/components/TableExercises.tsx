import { createColumnHelper, flexRender, getCoreRowModel, getPaginationRowModel, useReactTable } from '@tanstack/react-table';
import { FaPencil, FaTrash } from 'react-icons/fa6';

const columnHelper = createColumnHelper<any>();

const columns = [
    columnHelper.accessor('name', {
        cell: info => info.getValue(),
        header: () => 'Ejercicio',
    }),
    columnHelper.accessor('exerciseClassification.description', {
        cell: info => info.getValue(),
        header: () => 'Tipo',
    }),
    columnHelper.accessor('muscleGroup.description', {
        cell: info => info.getValue(),
        header: () => 'Zona',
    })
]

export default function TableExercises({ data, onEdit, onDelete }: any) {

    const table = useReactTable(
        {
            data,
            columns,
            getCoreRowModel: getCoreRowModel(),
            getPaginationRowModel: getPaginationRowModel()
        }
    );

    return (
        <div className="w-full md:px-5 mx-auto" style={{ maxWidth: "1000px" }}>
            <table className="table-auto w-full">
                <thead>
                    {table.getHeaderGroups().map(headerGroup => (
                        <tr key={headerGroup.id} className="bg-black text-white">
                            {headerGroup.headers.map(header => (
                                <th key={header.id} className="text-xs md:text-sm border-1 border-gray-400">
                                    {header.isPlaceholder ? null : flexRender(header.column.columnDef.header, header.getContext())}
                                </th>
                            ))}
                            <th className="text-xs md:text-sm border-1 border-gray-400">Editar</th>
                            <th className="text-xs md:text-sm border-1 border-gray-400">Eliminar</th>
                        </tr>
                    ))}
                </thead>
                <tbody>
                    {table.getRowModel().rows.map(row => (
                        <tr key={row.id}>
                            {row.getVisibleCells().map(cell => (
                                <td key={cell.id} className="text-xs md:text-sm border-1 border-gray-400 p-1">
                                    {flexRender(cell.column.columnDef.cell, cell.getContext())}
                                </td>
                            ))}
                            <td className="text-xs md:text-sm border-1 border-gray-400">
                                <button onClick={() => onEdit(row.original)} className="text-green-600">
                                    <FaPencil />
                                </button>
                            </td>
                            <td className="text-xs md:text-sm border-1 border-gray-400">
                                <button onClick={() => onDelete(row.original)} className="text-red-600">
                                    <FaTrash />
                                </button>
                            </td>
                        </tr>
                    ))}
                </tbody>
                <tr className="w-full flex flex-wrap" style={{ maxWidth: "320px" }}>
                    <td className="w-full flex flex-wrap" style={{ maxWidth: "320px" }}>
                        <div className="flex flex-wrap justify-between items-center gap-2 w-full mt-2" style={{ maxWidth: "320px" }}>
                            <div className='flex w-full'>
                                <button onClick={() => table.previousPage()} disabled={!table.getCanPreviousPage()} className="border-1 shadow-md shadow-gray-400">
                                    {'<'}
                                </button>
                                <span className="flex items-center text-center gap-1">
                                    <p className="font-semibold">{table.getState().pagination.pageIndex + 1}</p><p> de </p><p className="font-semibold">{table.getPageCount()}</p>
                                </span>
                                <button onClick={() => table.nextPage()} disabled={!table.getCanNextPage()} className="border-1 shadow-md shadow-gray-400">
                                    {'>'}
                                </button>
                            </div>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
    )
}
